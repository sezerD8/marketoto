using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class kategori
    {
        [Key]
        public int k_ID { get; set; }
        public string k_Adi { get; set; }
        public int k_kdv { get; set; }
    }
}
