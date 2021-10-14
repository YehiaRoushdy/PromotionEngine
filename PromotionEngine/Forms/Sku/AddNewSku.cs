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
            //Validations
            if (textBox1.Text == string.Empty)
                throw new Exception("Can't Save Without Entering SKU");
            if (numericUpDown1.Value == 0)
                throw new Exception("Can't Save Without Entering Price");
            string SKU = textBox1.Text;
            if (!Regex.IsMatch(SKU, @"^[a-zA-Z]+$"))
                throw new Exception("SKU Must Contain Only Letters");

            //Inserting New SKU
            decimal Price = numericUpDown1.Value;
            Helper.InsertingNewSKU(SKU, Price);
            this.Hide();
        }
    }
}
