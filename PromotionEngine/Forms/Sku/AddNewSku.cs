using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotionEngine.Forms.SKU
{
    public partial class AddNewSku : Form
    {
        public AddNewSku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                throw new Exception("Can't Save Without Entering SKU");
            if (numericUpDown1.Value == 0)
                throw new Exception("Can't Save Without Entering Price");
            string SKU = textBox1.Text;
            if (!Regex.IsMatch(SKU, @"^[a-zA-Z]+$"))
                throw new Exception("SKU Must Contain Only Letters");
            decimal Price = numericUpDown1.Value;
            System.Data.SqlClient.SqlConnection SQLConnection = Helper.Con;
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO dbo.Sku (Sku, Price) VALUES ('" + SKU + "', " + Price + ")";
            cmd.Connection = SQLConnection;
            SQLConnection.Open();
            cmd.ExecuteNonQuery();
            SQLConnection.Close();
            MessageBox.Show("New SKU Was Saved Successfully", "Success", MessageBoxButtons.OK);
            this.Hide();
        }
    }
}
