using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                Application.Run(new MainForm(loginForm.LoggedInUser));
            }
        }
    }
}
