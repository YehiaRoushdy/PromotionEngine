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
            this.skuTableAdapter.Fill(this.promotionEngineDBDataSet.Sku);
            this.promotionDetailTableAdapter.Fill(this.promotionEngineDBDataSet.PromotionDetail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView dataGridView = this.dataGridView1;
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;

            if (textBox1.Text == string.Empty)
                throw new Exception("Can't Save Without Entering Promotion Name");

            //Inserting Promotion
            string PromotionName = textBox1.Text;
            Helper.InsertingNewPromotion(PromotionName);

            //Getting The Inserted Promotion ID to Link It To Promotion Detail Records On Insertion
            int PromotionId = Helper.GettingPromotionId(PromotionName);

            //Inserting Promotion Details
            decimal Total = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                //Getting SKU_ID
                string SKU = row.Cells[0].Value.ToString();
                int SKU_Id = Convert.ToInt32(Helper.GettingSkuIdAndPrice(SKU)[0]);

                //Inserting in Promotion Detail Table
                decimal Quantity = Convert.ToInt32(row.Cells[1].Value);
                decimal Price = Convert.ToDecimal(row.Cells[2].Value);
                Total += Price;
                Helper.InsertingNewPromotionDetail(PromotionId, SKU_Id, Quantity, Price);
            }

            //Updating Promotion Total Value
            Helper.UpdatingPromotionRecord(PromotionId, Total);
          
            this.Hide();
        }
    }
}
