using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikasi_PenjualanEF.Entities;
using System.Windows.Forms;

namespace Aplikasi_PenjualanEF.Forms
{
    public partial class fmBarang : Form
    {
        public fmBarang()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "SELECT * FROM tbl_barang";
                barangBindingSource.DataSource = db.Query<Barang>(query, commandType: CommandType.Text);
                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
