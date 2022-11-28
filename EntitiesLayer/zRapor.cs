using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class zRapor
    {
        [Key]
        public int z_ID { get; set; }
        public string  z_Tarih { get; set; }
        public decimal z_krediToplam { get; set; }
        public decimal z_nakitToplam { get; set; }
        public decimal z_cekToplam { get; set; }
        public decimal z_Ciro { get; set; }
    }
}
