using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class musteri
    {
        [Key]
        public int mu_ID { get; set; }
        public string mu_TC { get; set; }
        public string mu_Adi { get; set; }
        public string mu_Adres { get; set; }
        public string mu_Tel { get; set; }

    }
}
