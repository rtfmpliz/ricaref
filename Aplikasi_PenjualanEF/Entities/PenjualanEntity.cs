using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_PenjualanEF.Entities
{
    [Table("tbl_penjualan")]
    public class PenjualanEntity
    {
        [Key]
        public string NoKwitansi { get; set; }
        public DateTime TglKwitansi { get; set; }
        public string IDPelanggan { get; set; }
    }
}
