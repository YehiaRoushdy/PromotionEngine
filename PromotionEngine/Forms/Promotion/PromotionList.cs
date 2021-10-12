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
    public partial class PromotionList : Form
    {
        public PromotionList()
        {
            InitializeComponent(); 
            BindGrid();
        }

        private void BindGrid()
        {
            string constring = Helper.str;
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Promotion", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
