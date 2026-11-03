using System.ComponentModel;

namespace EntitiesLayer
{
    public class Supplier
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Adı")]
        public string Name { get; set; }

        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Tel")]
        public string Phone { get; set; }
    }
}
