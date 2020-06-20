﻿using Aplikasi_PenjualanEF.Entities;
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
using System.Windows.Forms;

namespace Aplikasi_PenjualanEF.Forms
{
    public partial class fmTransaksi : Form
    {
        public fmTransaksi()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "SELECT * FROM tbl_penjualan";
                penjualanEntityBindingSource.DataSource = db.Query<PenjualanEntity>(query, commandType: CommandType.Text);

            }
        }
    }
}
