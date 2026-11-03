using System.ComponentModel;

namespace EntitiesLayer
{
    public class User
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [Browsable(false)]
        public string PasswordHash { get; set; }

        [DisplayName("Yetki")]
        public bool IsAdmin { get; set; }
    }
}
