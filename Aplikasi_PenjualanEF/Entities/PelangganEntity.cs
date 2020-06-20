using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_PenjualanEF.Entities
{
    [Table("tbl_pelanggan")]
    public class PelangganEntity
    {
        [Key]
        public string IDPelanggan { get; set; }
        public string NamaPelanggan { get; set; }
        public string Alamat { get; set; }
        public string NoTelepon { get; set; }
    }
}
