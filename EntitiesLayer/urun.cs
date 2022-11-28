using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class urun
    {
        [Key]
        public int u_ID { get; set; }
        public string u_Kod { get; set; }
        public string u_Aciklama { get; set; }
        public decimal u_SatisFiyat { get; set; }
        public decimal u_AlisFiyat { get; set; }
        public int u_Stok { get; set; }
        public virtual birim u_BirimID { get; set; }
        public virtual kategori u_KategoriID { get; set; }
        public virtual marka u_MarkaID { get; set; }
        public virtual toptanci u_ToptanciID { get; set; }
        public Nullable<int> Birim { get; set; }
        public Nullable<int> Kategori { get; set; }
        public Nullable<int> Marka { get; set; }
        public Nullable<int> Toptanci { get; set; }
    }
}
