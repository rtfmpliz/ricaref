using Aplikasi_PenjualanEF.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_PenjualanEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmBarang fmB = new fmBarang();
            fmB.Show();
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmTransaksi fmT = new fmTransaksi();
            fmT.Show();
        }
    }
}
