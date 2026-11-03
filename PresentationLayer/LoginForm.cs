using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using EntitiesLayer;
using LogicLayer;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoggedInUser = LogicProcess.Login(txtUsername.Text, txtPassword.Text);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı.\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LoggedInUser == null)
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
                return;
            }

            MessageBox.Show("Hoş geldiniz " + LoggedInUser.Username);
            DialogResult = DialogResult.OK;
        }
    }
}
