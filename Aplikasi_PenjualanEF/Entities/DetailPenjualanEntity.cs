using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_PenjualanEF.Entities
{
    [Table("tbl_detailpenjualan")]
    public class DetailPenjualanEntity
    {
        public string NoKwitansi { get; set; }
        public string KodeBarang { get; set; }
        public int Jumlah { get; set; }
    }
}
