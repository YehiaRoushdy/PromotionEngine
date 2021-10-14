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

namespace PromotionEngine.Forms.Order
{
    public partial class AddNewOrder : Form
    {
        public AddNewOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oString = "";
            SqlCommand cmd = null;
            DataGridView dataGridView = this.dataGridView1;
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;


            //decimal Total = 0;
            //foreach (DataGridViewRow row in dataGridView.Rows)
            //{
            //    if (row.Cells[0].Value == null)
            //        continue;
            //    string SKU = row.Cells[0].Value.ToString();
            //    int SKU_Id = 0;
            //    oString = "Select * from SKU where Sku=@Sku";
            //    cmd = new SqlCommand(oString, SQLConnection);
            //    cmd.Parameters.AddWithValue("@Sku", SKU);
            //    SQLConnection.Open();
            //    using (SqlDataReader oReader = cmd.ExecuteReader())
            //    {
            //        while (oReader.Read())
            //        {
            //            SKU_Id = Convert.ToInt32(oReader["Id"]);
            //        }
            //        SQLConnection.Close();
            //    }
            //    decimal Quantity = Convert.ToInt32(row.Cells[1].Value);
            //    decimal Price = Convert.ToDecimal(row.Cells[2].Value);
            //    Total += Price;
            //    cmd = new System.Data.SqlClient.SqlCommand();
            //    cmd.CommandType = System.Data.CommandType.Text;
            //    cmd.CommandText = "INSERT INTO dbo.PromotionDetail (Promotion_Id,Sku_Id,Quantity,Price) " +
            //        "VALUES (" + PromotionId + "," + SKU_Id + "," + Quantity + "," + Price + ")";
            //    cmd.Connection = SQLConnection;
            //    SQLConnection.Open();
            //    cmd.ExecuteNonQuery();
            //    SQLConnection.Close();
            //}


            //this.Hide();
        }

        private void AddNewOrder_Load(object sender, EventArgs e)
        {
            this.skuTableAdapter.Fill(this.promotionEngineDBDataSet.Sku);
            this.cartItemTableAdapter.Fill(this.promotionEngineDBDataSet.CartItem);
            this.dateTimePicker1.Value = DateTime.Now;
            this.textBox1.Text = "0";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string oString = "";
            SqlCommand cmd = null;
            decimal RowTotal = 0;
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "quantityDataGridViewTextBoxColumn")
            {
                int CurrentQuantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                DataGridViewRow gridrow = dataGridView1.Rows[e.RowIndex];
                if (gridrow.Cells[0].Value == null)
                    return;
                else
                {
                    string SKU = gridrow.Cells[0].Value.ToString();
                    int SKU_Id = 0;
                    decimal Price = 0;

                    //Getting SKU_ID
                    oString = "Select * from SKU where Sku='" + SKU + "'";
                    cmd = new SqlCommand(oString, SQLConnection);
                    SQLConnection.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            SKU_Id = Convert.ToInt32(oReader["Id"]);
                            Price = Convert.ToDecimal(oReader["Price"]);
                        }
                        SQLConnection.Close();
                    }

                    //Getting Promotion For The SKU
                    int PromotionQuantity = 0;
                    decimal PromotionPrice = 0;
                    oString = "Select * from PromotionDetail where Sku_Id='" + SKU_Id + "'";
                    cmd = new SqlCommand(oString, SQLConnection);
                    SQLConnection.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            PromotionQuantity = Convert.ToInt32(oReader["Quantity"]);
                            PromotionPrice = Convert.ToDecimal(oReader["Price"]);
                        }
                        SQLConnection.Close();
                    }

                    //Getting In Promotion and Left Out Quantity
                    int LeftOutPromotionQuantity = CurrentQuantity - PromotionQuantity;
                    RowTotal += PromotionPrice;

                    decimal LeftOutPromotionPrice = Price * LeftOutPromotionQuantity;
                    RowTotal += LeftOutPromotionPrice;


                    //Setting Total In The New Cell
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = RowTotal;

                    decimal OrderTotal = Convert.ToDecimal(this.textBox1.Text);
                    OrderTotal += RowTotal;
                    this.textBox1.Text = OrderTotal.ToString();

                }
            }

        }
    }
}
