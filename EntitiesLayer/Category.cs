using System.ComponentModel;

namespace EntitiesLayer
{
    public class Category
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Adı")]
        public string Name { get; set; }

        [DisplayName("KDV")]
        public int VatRate { get; set; }
    }
}
