using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class birim 
    {
        [Key]
        public int b_ID{ get; set; }
        public string b_Adi{ get; set; }
    }
}
