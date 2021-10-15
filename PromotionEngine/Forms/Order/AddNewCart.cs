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
    public partial class AddNewCart : Form
    {
        public AddNewCart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oString = "";
            SqlCommand cmd = null;
            DataGridView dataGridView = this.dataGridView1;
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;

            if (textBox1.Text == string.Empty)
                throw new Exception("Can't Save Without Entering Promotion Name");


            decimal Cart_Total = Convert.ToDecimal(this.textBox1.Text);

            //Inserting Cart
            Helper.InsertingNewCart(this.dateTimePicker1.Value, Cart_Total);


            //Getting The Inserted Cart ID to Link It To Cart Item On Insertion
            int Cart_Id = Helper.GettingCartId(this.dateTimePicker1.Value, Cart_Total);


            //Inserting Order Details
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;
                //Getting SKU_ID
                string SKU = row.Cells[0].Value.ToString();
                int SKU_Id = Convert.ToInt32(Helper.GettingSkuIdAndPrice(SKU)[0]);

                //Inserting in Cart Item Table
                decimal Quantity = Convert.ToInt32(row.Cells[1].Value);
                decimal Total = Convert.ToDecimal(row.Cells[2].Value);
                Helper.InsertingNewCartItem(SKU_Id, Cart_Id, Quantity, Total);
            }
            this.Hide();
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
                    int SKU_Id = Convert.ToInt32(Helper.GettingSkuIdAndPrice(SKU)[0]);
                    decimal Price = Convert.ToDecimal(Helper.GettingSkuIdAndPrice(SKU)[1]);


                    //Getting Promotion For The SKU
                    int PromotionQuantity = Convert.ToInt32(Helper.GettingPromotionQuantityAndPrice(SKU_Id)[0]);
                    decimal PromotionPrice = Convert.ToDecimal(Helper.GettingPromotionQuantityAndPrice(SKU_Id)[1]);


                    //Calculating Row Total
                    RowTotal = Helper.CalculateSKUTotal(PromotionQuantity, CurrentQuantity, Price, PromotionPrice);

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
