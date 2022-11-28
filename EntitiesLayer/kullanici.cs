using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class kullanici
    {
        [Key]
        public int ku_ID { get; set; }
        public string ku_Adi { get; set; }
        public string ku_Sifre { get; set; }
        public bool ku_Yetki{ get; set; }
    }
}
