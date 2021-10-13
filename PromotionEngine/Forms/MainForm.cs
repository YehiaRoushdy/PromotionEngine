using PromotionEngine.Forms.SKU;
using PromotionEngine.Forms.Promotion;

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

namespace PromotionEngine.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Helper.Con = new SqlConnection(Helper.str);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Create_SKU_Click(object sender, EventArgs e)
        {
            AddNewSku AddNewSKUForm = new AddNewSku();
            AddNewSKUForm.Show();
        }

        private void Add_New_Order_Click(object sender, EventArgs e)
        {

        }

        private void View_Previous_Orders_Click(object sender, EventArgs e)
        {

        }

        private void View_SKU_List_Click(object sender, EventArgs e)
        {
            SkuList SkuListForm = new SkuList();
            SkuListForm.Show();
        }

        private void Create_Promotion_Click(object sender, EventArgs e)
        {
            AddNewPromotion AddNewPromotionForm = new AddNewPromotion();
            AddNewPromotionForm.Show();
        }

        private void View_Promotions_List_Click(object sender, EventArgs e)
        {
            PromotionList PromotionListForm = new PromotionList();
            PromotionListForm.Show();
        }
    }
}
