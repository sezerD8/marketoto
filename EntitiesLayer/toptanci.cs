using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class toptanci
    {
        [Key]
        public int t_ID { get; set; }
        public string t_Adi { get; set; }
        public string t_Adres { get; set; }
        public string t_Tel { get; set; }
    }
}
