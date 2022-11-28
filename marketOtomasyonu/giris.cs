using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntitiesLayer;
using LogicLayer;

namespace marketOtomasyonu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public kullanici kul = new kullanici();
        public static marketOtomasyonu marketOtomasyonuForm = new marketOtomasyonu();
        public void button1_Click_1(object sender, EventArgs e)
        {
            logicProcess.kullaniciList();
            
            // KULLANICI GİRİŞ KONTROLÜ
            kul.ku_Adi = textBox1.Text;
            kul.ku_Sifre = textBox2.Text;
            if (logicProcess.kullaniciAdiKontrol(kul))
            {
                MessageBox.Show("Hoş geldiniz " + kul.ku_Adi);
                this.Hide();
                marketOtomasyonuForm.Show();
                marketOtomasyonuForm.dataGridView7.DataSource = logicProcess.kullaniciYetkiList(kul);
                if (Convert.ToBoolean(marketOtomasyonuForm.dataGridView7.Rows[0].Cells[3].Value))
                {
                    marketOtomasyonuForm.Text = "Market Otomasyonu " + "(admin)";
                }
                else
                {
                    marketOtomasyonuForm.Text = "Market Otomasyonu " + "(personel)";
                    marketOtomasyonuForm.tabControl1.TabPages.Remove(marketOtomasyonuForm.tabPage9);
                    marketOtomasyonuForm.tabControl1.TabPages.Remove(marketOtomasyonuForm.tabPage8);
                    marketOtomasyonuForm.tabControl1.TabPages.Remove(marketOtomasyonuForm.tabPage7);
                    marketOtomasyonuForm.tabControl1.TabPages.Remove(marketOtomasyonuForm.tabPage6);
                    marketOtomasyonuForm.tabControl1.TabPages.Remove(marketOtomasyonuForm.tabPage5);
                    marketOtomasyonuForm.tabControl1.TabPages.Remove(marketOtomasyonuForm.tabPage4);
                    marketOtomasyonuForm.txtBox_zNakit.Enabled = false;
                    marketOtomasyonuForm.txtBox_zKart.Enabled = false;
                    marketOtomasyonuForm.txtBox_zCek.Enabled = false;
                    marketOtomasyonuForm.txtBox_zCiro.Enabled = false;
                    marketOtomasyonuForm.button22.Enabled = false;
                    marketOtomasyonuForm.button24.Enabled = false;

                }
            }
            else
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
        }

    }
}
