using EntitiesLayer;
using DataAccessLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Metadata.Edm;

namespace marketOtomasyonu
{
    public partial class marketOtomasyonu : Form
    {
        public marketOtomasyonu()
        {
            InitializeComponent();
        }
        void birimListele()
        {
            dataGridView2.DataSource = logicProcess.birimList();
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*KULLANICI İŞLEMLERİ*///////////////////////

        kullanici kul = new kullanici();
        private void button13_Click(object sender, EventArgs e)
        {
            kul.ku_Adi = txtBox_KullaniciAdi.Text;
            kul.ku_Sifre = txtBox_Sifre.Text;
            if (checkBox1.Checked == true)
            {
                kul.ku_Yetki = true;
            }
            else
            {
                kul.ku_Yetki = false;
            }
            logicProcess.kullaniciEkle(kul);
            kullanıcıListele();
        }
        public bool yetki;
        private void marketOtomasyonu_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID",30);
            listView1.Columns.Add("ÜRÜN ADI", 130);
            listView1.Columns.Add("ÜRÜN FİYATI", 85);
            giris girisForm = new giris();
            musteriListele();
            zRaporListele();
            urunListele();
            kategoriListele();
            toptanciListele();
            markaListele();
            birimListele();
            kullanıcıListele();
        }

        void kullanıcıListele()
        {
            dataGridView7.DataSource = logicProcess.kullaniciList();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                kul.ku_ID = Convert.ToInt32(txtBox_KullaniciID.Text);
                logicProcess.kullaniciSil(kul.ku_ID);
                kullanıcıListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                kul.ku_ID = Convert.ToInt32(txtBox_KullaniciID.Text);
                kul.ku_Adi = txtBox_KullaniciAdi.Text;
                kul.ku_Sifre = txtBox_Sifre.Text;
                if (checkBox1.Checked)
                {
                    kul.ku_Yetki = true;
                }
                else
                {
                    kul.ku_Yetki = false;
                }
                logicProcess.kullaniciGuncelle(kul);
                kullanıcıListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////*BİRİM İŞLEMLERİ*/////////////////////////////////////
        birim brm = new birim();
        myDbContext db = new myDbContext();
        private void btn_BirimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                brm.b_Adi = txtBox_BirimAdi.Text;
                logicProcess.birimEkle(brm);
                birimListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btn_BirimDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                brm.b_ID = Convert.ToInt32(txtBox_BirimID.Text);
                brm.b_Adi = txtBox_BirimAdi.Text;
                logicProcess.birimGuncelle(brm);
                birimListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.");
            }
        }

        private void btn_BirimSil_Click(object sender, EventArgs e)
        {
            try
            {
                brm.b_ID = Convert.ToInt32(txtBox_BirimID.Text);
                logicProcess.birimSil(brm.b_ID);
                birimListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek verinin ID'sini giriniz");
            }
        }

        private void comboBox_Birim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Birim.SelectedValue.ToString());
            var birim = db.tbl_birim.Where(x => x.b_ID == id).Select(y => y.b_Adi).FirstOrDefault();
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*ÜRÜN İŞLEMLERİ*///////////////////////

        urun urn = new urun();
        void urunListele()
        {
            var birim = (from x in db.tbl_birim
                         select new
                         {
                             x.b_ID,
                             x.b_Adi,
                         }).ToList();

            var kategori = (from x in db.tbl_kategori
                            select new
                            {
                                x.k_ID,
                                x.k_Adi,
                                x.k_kdv,
                            }).ToList();

            var marka = (from x in db.tbl_marka
                            select new
                            {
                                x.m_ID,
                                x.m_Adi,
                            }).ToList();

            var toptanci = (from x in db.tbl_toptanci
                         select new
                         {
                             x.t_ID,
                             x.t_Adi,
                             x.t_Adres,
                             x.t_Tel
                         }).ToList();


            dataGridView1.DataSource = (from z in db.tbl_urun
                                        select new
                                        {
                                            z.u_ID,
                                            z.u_Kod,
                                            z.u_Aciklama,
                                            z.u_SatisFiyat,
                                            z.u_AlisFiyat,
                                            z.u_Stok,
                                            z.u_BirimID.b_Adi,
                                            z.u_KategoriID.k_Adi,
                                            z.u_MarkaID.m_Adi,
                                            z.u_ToptanciID.t_Adi,
                                        }).ToList();


            dataGridView8.DataSource = (from a in db.tbl_urun
                                        select new
                                        {
                                            a.u_ID,
                                            a.u_Kod,
                                            a.u_Aciklama,
                                            a.u_SatisFiyat,
                                            a.u_AlisFiyat,
                                            a.u_Stok,
                                            a.u_BirimID.b_Adi,
                                            a.u_KategoriID.k_Adi,
                                            a.u_MarkaID.m_Adi,
                                            a.u_ToptanciID.t_Adi,
                                        }).ToList();

            comboBox_Birim.ValueMember = "b_ID";
            comboBox_Birim.DisplayMember = "b_Adi";
            comboBox_Birim.DataSource = birim;

            comboBox_Kategori.ValueMember = "k_ID";
            comboBox_Kategori.DisplayMember = "k_Adi";
            comboBox_Kategori.DataSource = kategori;

            comboBox_Marka.ValueMember = "m_ID";
            comboBox_Marka.DisplayMember = "m_Adi";
            comboBox_Marka.DataSource = marka;
            
            comboBox_Toptanci.ValueMember = "t_ID";
            comboBox_Toptanci.DisplayMember = "t_Adi";
            comboBox_Toptanci.DataSource = toptanci;
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                urn.u_Kod = txtBox_Kod.Text;
                urn.u_Aciklama = txtBox_Aciklama.Text;
                urn.u_SatisFiyat = Convert.ToDecimal(txtBox_SatisFiyat.Text);
                urn.u_AlisFiyat = Convert.ToDecimal(txtBox_AlisFiyat.Text);
                urn.u_Stok = Convert.ToInt32(txtBox_Stok.Text);
                urn.Birim = int.Parse(comboBox_Birim.SelectedValue.ToString());
                urn.Kategori = int.Parse(comboBox_Kategori.SelectedValue.ToString());
                urn.Marka = int.Parse(comboBox_Marka.SelectedValue.ToString());
                urn.Toptanci = int.Parse(comboBox_Toptanci.SelectedValue.ToString());
                logicProcess.urunEkle(urn);
                urunListele();
                MessageBox.Show("Ürün Eklendi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                urn.u_ID = Convert.ToInt32(txtBox_ID.Text);
                logicProcess.urunSil(urn.u_ID);
                MessageBox.Show("Ürün silindi");
                urunListele();
            }
            catch (Exception)
            {

                MessageBox.Show("Silinecek verinin ID'sini giriniz");
            }
        }


        private void btn_UrunDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                urn.u_ID = Convert.ToInt32(txtBox_ID.Text);
                urn.u_Kod = txtBox_Kod.Text;
                urn.u_Aciklama = txtBox_Aciklama.Text;
                urn.u_SatisFiyat = Convert.ToInt32(txtBox_SatisFiyat.Text);
                urn.u_AlisFiyat = Convert.ToInt32(txtBox_AlisFiyat.Text);
                urn.u_Stok = Convert.ToInt32(txtBox_Stok.Text);
                urn.Birim = int.Parse(comboBox_Birim.SelectedValue.ToString());
                urn.Kategori = int.Parse(comboBox_Kategori.SelectedValue.ToString());
                urn.Marka = int.Parse(comboBox_Marka.SelectedValue.ToString());
                urn.Toptanci = int.Parse(comboBox_Toptanci.SelectedValue.ToString());
                logicProcess.urunGuncelle(urn);
                MessageBox.Show("Ürün düzenlendi");
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*KATEGORİ İŞLEMLERİ*///////////////////////
        void kategoriListele()
        {
            dataGridView3.DataSource = logicProcess.kategoriList();
        }


        kategori kate = new kategori();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                kate.k_Adi = txtBox_KategoriAdi.Text;
                kate.k_kdv = Convert.ToInt32(txtBox_KategoriKDV.Text);
                logicProcess.kategoriEkle(kate);
                kategoriListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kate.k_ID = Convert.ToInt32(txtBox_KategoriID.Text);
                kate.k_Adi = txtBox_KategoriAdi.Text;
                kate.k_kdv = Convert.ToInt32(txtBox_KategoriKDV.Text);
                logicProcess.kategoriGuncelle(kate);
                kategoriListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                kate.k_ID = Convert.ToInt32(txtBox_KategoriID.Text);
                logicProcess.kategoriSil(kate.k_ID);
                kategoriListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek verinin ID'sini giriniz");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*MARKA İŞLEMLERİ*///////////////////////
        marka mark = new marka();
        void markaListele()
        {
            dataGridView4.DataSource = logicProcess.markaList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                mark.m_Adi = txtBox_MarkaAdi.Text;
                logicProcess.markaEkle(mark);
                markaListele();
                urunListele();
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                mark.m_ID = Convert.ToInt32(txtBox_MarkaID.Text);
                mark.m_Adi = txtBox_MarkaAdi.Text;
                logicProcess.markaGuncelle(mark);
                markaListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                mark.m_ID = Convert.ToInt32(txtBox_MarkaID.Text);
                logicProcess.markaSil(mark.m_ID);
                markaListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek verinin ID'sini giriniz");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*TOPTANCI İŞLEMLERİ*///////////////////////
        toptanci toptan = new toptanci();
        void toptanciListele()
        {
            dataGridView5.DataSource = logicProcess.toptanciList();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            try
            {
                toptan.t_Adi = txtBox_ToptanciAdi.Text;
                toptan.t_Adres = txtBox_ToptanciAdres.Text;
                toptan.t_Tel = txtBox_ToptanciTel.Text;
                logicProcess.toptanciEkle(toptan);
                toptanciListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                toptan.t_ID = Convert.ToInt32(txtBox_ToptanciID.Text);
                toptan.t_Adi = txtBox_ToptanciAdi.Text;
                toptan.t_Adres = txtBox_ToptanciAdres.Text;
                toptan.t_Tel = txtBox_ToptanciTel.Text;
                logicProcess.toptanciGuncelle(toptan);
                toptanciListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                toptan.t_ID = Convert.ToInt32(txtBox_ToptanciID.Text);
                logicProcess.toptanciSil(toptan.t_ID);
                toptanciListele();
                urunListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek verinin ID'sini giriniz");
            }
            
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*MÜŞTERİ İŞLEMLERİ*///////////////////////
        musteri must = new musteri();
        void musteriListele()
        {
            dataGridView6.DataSource = logicProcess.musteriList();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                must.mu_TC = txtBox_MusteriTC.Text;
                must.mu_Adi = txtBox_MusteriAdi.Text;
                must.mu_Adres = txtBox_MusteriAdres.Text;
                must.mu_Tel = txtBox_MusteriTel.Text;
                logicProcess.musteriEkle(must);
                musteriListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            try
            {
                must.mu_ID = Convert.ToInt32(txtBox_MusteriID.Text);
                must.mu_TC = txtBox_MusteriTC.Text;
                must.mu_Adi = txtBox_MusteriAdi.Text;
                must.mu_Adres = txtBox_MusteriAdres.Text;
                must.mu_Tel = txtBox_MusteriTel.Text;
                logicProcess.musteriGuncelle(must);
                musteriListele();

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş \nDüzenlenecek verinin ID'sini girmeyi unutmayınız.");
            }
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            try
            {
                must.mu_ID = Convert.ToInt32(txtBox_MusteriID.Text);
                logicProcess.musteriSil(must.mu_ID);
                musteriListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek verinin ID'sini giriniz");
            }
        }

        private void comboBox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Birim.SelectedValue.ToString());
            var kategori = db.tbl_birim.Where(x => x.b_ID == id).Select(y => y.b_Adi).FirstOrDefault();
        }

        private void comboBox_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Birim.SelectedValue.ToString());
            var marka = db.tbl_birim.Where(x => x.b_ID == id).Select(y => y.b_Adi).FirstOrDefault();
        }

        private void comboBox_Toptanci_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Birim.SelectedValue.ToString());
            var toptanci = db.tbl_birim.Where(x => x.b_ID == id).Select(y => y.b_Adi).FirstOrDefault();
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*SATIŞ İŞLEMLERİ*///////////////////////
        urun urunsatis = new urun();
        void urunAraAciklama()
        {
            dataGridView8.DataSource = (from z in db.tbl_urun
                                        where z.u_Aciklama == txtBox_AciklamaAra.Text
                                        select new
                                        {
                                            z.u_ID,
                                            z.u_Kod,
                                            z.u_Aciklama,
                                            z.u_SatisFiyat,
                                            z.u_AlisFiyat,
                                            z.u_Stok,
                                            z.u_BirimID.b_Adi,
                                            z.u_KategoriID.k_Adi,
                                            z.u_MarkaID.m_Adi,
                                            z.u_ToptanciID.t_Adi,
                                        }).ToList();
        }
        
        void urunAraKod()
        {
            dataGridView8.DataSource = (from z in db.tbl_urun
                                        where z.u_Kod == txtBox_KodAra.Text
                                        select new
                                        {
                                            z.u_ID,
                                            z.u_Kod,
                                            z.u_Aciklama,
                                            z.u_SatisFiyat,
                                            z.u_AlisFiyat,
                                            z.u_Stok,
                                            z.u_BirimID.b_Adi,
                                            z.u_KategoriID.k_Adi,
                                            z.u_MarkaID.m_Adi,
                                            z.u_ToptanciID.t_Adi,
                                        }).ToList();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            urunAraAciklama();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            urunAraKod();
        }

        decimal tutarToplam = 0;
        decimal fiyat = 0;
        int index;
        List<int> urunIndex = new List<int>();
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = dataGridView8.SelectedCells[0].RowIndex;
                urunIndex.Add(Convert.ToInt32(dataGridView8.Rows[secilen].Cells[0].Value.ToString()));
                string[] row = { dataGridView8.Rows[secilen].Cells[0].Value.ToString(), dataGridView8.Rows[secilen].Cells[2].Value.ToString(), dataGridView8.Rows[secilen].Cells[3].Value.ToString() };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
                tutarToplam += Convert.ToDecimal(dataGridView8.Rows[secilen].Cells[3].Value.ToString());
                txtBox_SepetTutar.Text = tutarToplam.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün seçiniz.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (tutarToplam > 0)
                {
                    tutarToplam -= fiyat;
                    urunIndex.Remove(index);
                    button20.Text = urunIndex.Count.ToString();
                    txtBox_SepetTutar.Text = tutarToplam.ToString();
                }
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün seçiniz.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                fiyat = decimal.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                index = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }
        decimal nakit = 0;
        decimal kart = 0;
        decimal cek = 0;
        private void button20_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioBtn_Nakit.Checked)
            {
                try
                {
                    txtBox_ParaUstu.Text = (Convert.ToDecimal(txtBox_AlınanPara.Text) - Convert.ToDecimal(txtBox_SepetTutar.Text)).ToString();
                }
                catch (Exception)
                {

                }
                nakit += Convert.ToDecimal(txtBox_SepetTutar.Text);
            }
            else if (radioBtn_Kart.Checked)
            {
                kart += Convert.ToDecimal(txtBox_SepetTutar.Text);
            }
            else if (radioBtn_Cek.Checked)
            {
                cek += Convert.ToDecimal(txtBox_SepetTutar.Text);
            }
            DialogResult secim = MessageBox.Show("Sepeti tamamlamak istiyor musunuz?","SEPET ONAY",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (secim == DialogResult.Yes)
            {
                txtBox_AlınanPara.Text = " ";
                txtBox_ParaUstu.Text = " ";
                txtBox_SepetTutar.Text = " ";
                tutarToplam = 0;
                for (int i = 0; i < urunIndex.Count; i++)
                {
                    urn.u_ID = urunIndex[i];
                    urn.u_Stok = Convert.ToInt32(logicProcess.urunStok(urunIndex[i])) - 1;
                    logicProcess.urunStokGuncelle(urn);
                }
                listView1.Items.Clear();
                urunIndex.Clear();
                urunAraAciklama();
            }
        }

        private void radioBtn_Nakit_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = true;
        }

        private void radioBtn_Kart_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = false;
        }

        private void radioBtn_Cek_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Enabled = false;
        }

        DateTime date = DateTime.Today;
        private void button20_Click_1(object sender, EventArgs e)
        {
            DialogResult cevap=MessageBox.Show("Günü bitirmek istediğinizden emin misiniz?","Gün Sonu",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                txtBox_zTarih.Text = date.ToString("d");
                txtBox_zNakit.Text = nakit.ToString();
                txtBox_zKart.Text = kart.ToString();
                txtBox_zCek.Text = cek.ToString();
                txtBox_zCiro.Text = (nakit + kart + cek).ToString();
                dataGridView9.DataSource = logicProcess.zRaporList();
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage6);
                tabControl1.TabPages.Remove(tabPage7);
                tabControl1.TabPages.Remove(tabPage8);
                tabControl1.TabPages.Remove(tabPage9);
            }

        }
        zRapor rapor = new zRapor();
        void zRaporListele()
        {

            dataGridView9.DataSource = logicProcess.zRaporList();
        }
        private void button21_Click(object sender, EventArgs e)
        {

            try
            {
                rapor.z_Tarih = txtBox_zTarih.Text.ToString();
                rapor.z_krediToplam = Convert.ToDecimal(txtBox_zKart.Text);
                rapor.z_nakitToplam = Convert.ToDecimal(txtBox_zNakit.Text);
                rapor.z_cekToplam = Convert.ToDecimal(txtBox_zCek.Text);
                rapor.z_Ciro = Convert.ToDecimal(txtBox_zCiro.Text);
                if (logicProcess.zRaporKontrol(rapor))
                {
                    MessageBox.Show("Aynı günü tekrar ekliyorsunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logicProcess.zRaporEkle(rapor);
                }
                zRaporListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                rapor.z_ID = Convert.ToInt32(txtBox_zRaporID.Text);
                rapor.z_Tarih = txtBox_zTarih.Text;
                rapor.z_krediToplam = Convert.ToInt32(txtBox_zKart.Text);
                rapor.z_nakitToplam = Convert.ToInt32(txtBox_zNakit.Text);
                rapor.z_cekToplam = Convert.ToInt32(txtBox_zCek.Text);
                rapor.z_Ciro = Convert.ToInt32(txtBox_zCiro.Text);
                logicProcess.zRaporGuncelle(rapor);
                zRaporListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                rapor.z_ID = Convert.ToInt32(txtBox_zRaporID.Text);
                logicProcess.zRaporSil(rapor.z_ID);
                zRaporListele();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek günün ID bilgisini giriniz.");
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button19_Click(object sender, EventArgs e)
        {

            dataGridView6.DataSource = (from z in db.tbl_musteri
                                        where z.mu_Adi == textBox4.Text
                                        select new
                                        {
                                            z.mu_ID,
                                            z.mu_TC,
                                            z.mu_Adi,
                                            z.mu_Adres,
                                            z.mu_Tel
                                        }).ToList();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = (from z in db.tbl_musteri
                                        where z.mu_Tel == txtBox_MusteriTel.Text
                                        select new
                                        {
                                            z.mu_ID,
                                            z.mu_TC,
                                            z.mu_Adi,
                                            z.mu_Adres,
                                            z.mu_Tel
                                        }).ToList();
        }











        ///////////////////////////////////////////////////////////////////////////////////////
    }
}
