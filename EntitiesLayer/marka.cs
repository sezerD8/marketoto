using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class marka
    {
        [Key]
        public int m_ID { get; set; }
        public string m_Adi { get; set; }
    }
}
