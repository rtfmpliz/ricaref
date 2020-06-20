using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_PenjualanEF.Entities
{
    [Table("tbl_barang")]
    public class Barang
    {
        [Key]
        public string KodeBarang { get; set; }
        public string NamaBarang { get; set; }
        public int Harga { get; set; }
        public int Stock { get; set; }
        public string Satuan { get; set; }
    }
}
