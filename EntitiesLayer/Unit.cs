using System.ComponentModel;

namespace EntitiesLayer
{
    public class Unit
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Adı")]
        public string Name { get; set; }
    }
}
