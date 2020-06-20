using Aplikasi_PenjualanEF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_PenjualanEF.Reports
{
    public partial class fmTransaksiCetak : Form
    {
        private readonly PenjualanEntity _penjualanEntity;
        private readonly List<DetailPenjualanEntity> _list;

        public fmTransaksiCetak(PenjualanEntity penjualanEntity, List<DetailPenjualanEntity> list)
        {
            InitializeComponent();
            _penjualanEntity = penjualanEntity;
            _list = list;
        }

        private void fmTransaksi_Load(object sender, EventArgs e)
        {
            rptTransaksi1.SetDataSource(_list);
            rptTransaksi1.SetParameterValue("pNoKwitansi", _penjualanEntity.NoKwitansi);
            rptTransaksi1.SetParameterValue("pIdPelanggan", _penjualanEntity.IDPelanggan);
            //rptTransaksi1.SetParameterValue("pTanggalTransaksi", _penjualanEntity.TglKwitansi);

            crystalReportViewer1.ReportSource = rptTransaksi1;
            crystalReportViewer1.Refresh();
        }
    }
}
