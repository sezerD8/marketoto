using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DataAccessLayer;
using System.Runtime.Remoting.Contexts;
using System.Runtime.InteropServices.WindowsRuntime;

namespace LogicLayer
{
    public class logicProcess
    {
        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////BİRİM İŞLEMLERİ/////////////////////////
        public static List<birim> birimList()
        {
            return DALProcess.birimListesi();
        }
        public static int birimEkle(birim be)
        {
            if (be.b_Adi.Length > 1 && be.b_Adi != "")
            {
                return DALProcess.birimEkle(be);
            }
            else
            {
                return -1;
            }
        }
        public static void birimSil(int bs)
        {
            DALProcess.birimSil(bs);
        }

        public static bool birimGuncelle(birim bg)
        {
            if (bg.b_Adi.Length > 1 && bg.b_Adi != "")
            {
                DALProcess.birimGuncelle(bg);
                return true;
            }
            else
            {
                return false;

            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////KATEGORİ İŞLEMLERİ/////////////////////////
        public static List<kategori> kategoriList()
        {
            return DALProcess.kategoriListesi();
        }
        public static int kategoriEkle(kategori ke)
        {
            if (ke.k_Adi.Length > 1 && ke.k_Adi != "")
            {
                return DALProcess.kategoriEkle(ke);
            }
            else
            {
                return -1;
            }
        }
        public static void kategoriSil(int ks)
        {
            DALProcess.kategoriSil(ks);
        }

        public static bool kategoriGuncelle(kategori kg)
        {
            if (kg.k_Adi.Length > 1 && kg.k_Adi != "")
            {
                DALProcess.kategoriGuncelle(kg);
                return true;
            }
            else
            {
                return false;

            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////MARKA İŞLEMLERİ/////////////////////////
        public static List<marka> markaList()
        {
            return DALProcess.markaListesi();
        }
        public static int markaEkle(marka me)
        {
            if (me.m_Adi.Length > 1 && me.m_Adi != "")
            {
                return DALProcess.markaEkle(me);
            }
            else
            {
                return -1;
            }
        }
        public static void markaSil(int ms)
        {
            DALProcess.markaSil(ms);
        }

        public static bool markaGuncelle(marka mg)
        {
            if (mg.m_Adi.Length > 1 && mg.m_Adi != "")
            {
                DALProcess.markaGuncelle(mg);
                return true;
            }
            else
            {
                return false;

            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////TOPTANCI İŞLEMLERİ/////////////////////////
        public static List<toptanci> toptanciList()
        {
            return DALProcess.toptanciListesi();
        }
        public static int toptanciEkle(toptanci te)
        {
            if (te.t_Adi.Length > 1 && te.t_Adi != "")
            {
                return DALProcess.toptanciEkle(te);
            }
            else
            {
                return -1;
            }
        }
        public static void toptanciSil(int ts)
        {
            DALProcess.toptanciSil(ts);
        }

        public static bool toptanciGuncelle(toptanci tg)
        {
            if (tg.t_Adi.Length > 1 && tg.t_Adi != "")
            {
                DALProcess.toptanciGuncelle(tg);
                return true;
            }
            else
            {
                return false;

            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////MÜŞTERİ İŞLEMLERİ/////////////////////////
        public static List<musteri> musteriList()
        {
            return DALProcess.musteriListesi();
        }
        public static int musteriEkle(musteri me)
        {
            if (me.mu_Adi.Length > 1 && me.mu_Adi != "")
            {
                return DALProcess.musteriEkle(me);
            }
            else
            {
                return -1;
            }
        }
        public static void musteriSil(int ms)
        {
            DALProcess.musteriSil(ms);
        }

        public static bool musteriGuncelle(musteri mg)
        {
            if (mg.mu_Adi.Length > 1 && mg.mu_Adi != "")
            {
                DALProcess.musteriGuncelle(mg);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Müşteri adı boş geçilemez");
                return false;

            }
        }



        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////KULLANICI İŞLEMLERİ/////////////////////////

        public static List<kullanici> kullaniciList()
        {
            return DALProcess.kullaniciListesi();
        }
        public static List<kullanici> kullaniciYetkiList(kullanici y)
        {
            return DALProcess.kullaniciYetki(y);
        }

        //public static bool kullaniciYetki(kullanici e)
        //{
        //    if (e.ku_Yetki == true)
        //        return true;
        //    else
        //        return false;
        //}
        public static bool kullaniciEkle(kullanici a)
        {
            if (a.ku_Adi.Length > 2 && a.ku_Adi != "")
            {
                DALProcess.kullaniciEkle(a);
                return true;
            }
            else
                return false;
        }

        public static bool kullaniciAdiKontrol(kullanici k)
        {
            if (k.ku_Adi.Length > 2 && k.ku_Adi != "")
            {
                return DALProcess.kullaniciAdiKontrol(k);
                
            }
            else
                return false;

        }

        public static void kullaniciSil(int ms)
        {
            DALProcess.kullaniciSil(ms);
        }

        public static bool kullaniciGuncelle(kullanici kg)
        {
            if (kg.ku_Adi.Length > 2 && kg.ku_Adi != "")
            {
                DALProcess.kullaniciGuncelle(kg);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kullanıcı adı 2 karakterden fazla olmalı ve kullanıcı adı boş girilemez.");
                return false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////ÜRÜN İŞLEMLERİ/////////////////////////
        public static bool urunEkle(urun ue)
        {
            if (ue.u_Aciklama.Length > 2 && ue.u_Aciklama != "")
            {
                DALProcess.urunEkle(ue);
                return true;
            }
            else
                return false;
        }
        public static void urunSil(int ms)
        {
            DALProcess.urunSil(ms);
        }

        public static void urunStokGuncelle(urun ss)
        {
            DALProcess.urunStokGuncelle(ss);
        }
        public static bool urunGuncelle(urun ug)
        {
            if (ug.u_Aciklama.Length > 1 && ug.u_Aciklama != "")
            {
                DALProcess.urunGuncelle(ug);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Açıklama boş geçilemez");
                return false;

            }
        }

        public static string urunStok(int us)
        {
            return DALProcess.urunStok(us);
        }
        ////////////////////////////////////////////////////////////////////////////////
        /////////////////////zRAPOR İŞLEMLERİ/////////////////////////

        public static List<zRapor> zRaporList()
        {
            return DALProcess.zRaporListele();
        }

        public static bool zRaporEkle(zRapor ze)
        {
            if (ze.z_Tarih != null)
            {
                DALProcess.zRaporEkle(ze);
                return true;
            }
            else
                return false;
        }

        public static bool zRaporKontrol(zRapor zk)
        {
            if (zk.z_Tarih != null)
            {
                return DALProcess.zRaporKontrol(zk);

            }
            else
                return false;
        }

        public static void zRaporSil(int zs)
        {
            DALProcess.zRaporSil(zs);
        }
        public static bool zRaporGuncelle(zRapor zg)
        {
            if (zg.z_Tarih != "")
            {
                DALProcess.zRaporGuncelle(zg);
                return true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Açıklama boş geçilemez");
                return false;

            }
        }



    }
}
