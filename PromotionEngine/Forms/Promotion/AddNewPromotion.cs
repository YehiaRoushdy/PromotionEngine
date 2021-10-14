using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotionEngine.Forms.Promotion
{
    public partial class AddNewPromotion : Form
    {
        public AddNewPromotion()
        {
            InitializeComponent();
        }

        private void AddNewPromotion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'promotionEngineDBDataSet.Sku' table. You can move, or remove it, as needed.
            this.skuTableAdapter.Fill(this.promotionEngineDBDataSet.Sku);
            // TODO: This line of code loads data into the 'promotionEngineDBDataSet.PromotionDetail' table. You can move, or remove it, as needed.
            this.promotionDetailTableAdapter.Fill(this.promotionEngineDBDataSet.PromotionDetail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oString = "";
            SqlCommand cmd = null;
            DataGridView dataGridView = this.dataGridView1;
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;

            if (textBox1.Text == string.Empty)
                throw new Exception("Can't Save Without Entering Promotion Name");

            //Inserting Promotion
            string PromotionName = textBox1.Text;
            oString = "INSERT INTO dbo.Promotion (PromotionName) VALUES ('" + PromotionName + "')";
            cmd = new System.Data.SqlClient.SqlCommand(oString, SQLConnection);
            cmd.CommandType = System.Data.CommandType.Text;
            SQLConnection.Open();
            cmd.ExecuteNonQuery();
            SQLConnection.Close();

            //Getting The Inserted Promotion ID to Link It To Promotion Detail Records On Insertion
            int PromotionId = 0;
            oString = "Select * from Promotion where PromotionName=@PromotionName";
            SqlCommand oCmd = new SqlCommand(oString, SQLConnection);
            oCmd.Parameters.AddWithValue("@PromotionName", PromotionName);
            SQLConnection.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    PromotionId = Convert.ToInt32(oReader["Id"]);
                }
                SQLConnection.Close();
            }

            decimal Total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;
                //Getting SKU_ID
                string SKU = row.Cells[0].Value.ToString();
                int SKU_Id = 0;
                oString = "Select * from SKU where Sku=@Sku";
                cmd = new SqlCommand(oString, SQLConnection);
                cmd.Parameters.AddWithValue("@Sku", SKU);
                SQLConnection.Open();
                using (SqlDataReader oReader = cmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        SKU_Id = Convert.ToInt32(oReader["Id"]);
                    }
                    SQLConnection.Close();
                }

                //Inserting in Promotion Detail Table
                decimal Quantity = Convert.ToInt32(row.Cells[1].Value);
                decimal Price = Convert.ToDecimal(row.Cells[2].Value);
                Total += Price;
                cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.PromotionDetail (Promotion_Id,Sku_Id,Quantity,Price) " +
                    "VALUES (" + PromotionId + "," + SKU_Id + "," + Quantity + "," + Price + ")";
                cmd.Connection = SQLConnection;
                SQLConnection.Open();
                cmd.ExecuteNonQuery();
                SQLConnection.Close();
            }

            //Updating Promotion Total Value
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE Promotion SET Total = " + Total + 
                " WHERE " +
                "Id='" + PromotionId + "' ";
            cmd.Connection = SQLConnection;
            SQLConnection.Open();
            cmd.ExecuteNonQuery();
            SQLConnection.Close();

            this.Hide();
        }
    }
}
