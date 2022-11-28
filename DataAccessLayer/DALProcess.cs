using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using EntitiesLayer;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DALProcess
    {
        ////////////////////KULLANICI İŞLEMLERİ/////////////////////
        public static List<kullanici> kullaniciListesi()
        {
            List<kullanici> list = new List<kullanici>();
            SqlCommand komut = new SqlCommand("Select * from kullanicis", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kullanici user = new kullanici();
                user.ku_ID = Convert.ToInt32(dr["ku_ID"]);
                user.ku_Adi = dr["ku_Adi"].ToString();
                user.ku_Sifre = dr["ku_Sifre"].ToString();
                user.ku_Yetki = Convert.ToBoolean(dr["ku_Yetki"]);
                list.Add(user);
            }
            dr.Close();
            return list;
        }

        public static int kullaniciEkle(kullanici n)
        {
            SqlCommand ekle = new SqlCommand("Insert into kullanicis (ku_Adi,ku_Sifre,ku_Yetki) values (@k,@s,@y)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@k", n.ku_Adi);
            ekle.Parameters.AddWithValue("@s", n.ku_Sifre);
            ekle.Parameters.AddWithValue("@y", n.ku_Yetki);
            return ekle.ExecuteNonQuery();
        }

        public static bool kullaniciAdiKontrol(kullanici n)
        {
            SqlCommand kadikontrol = new SqlCommand($"select * from kullanicis where ku_Adi='{n.ku_Adi}' and ku_Sifre='{n.ku_Sifre}'", connect.db);
            if (kadikontrol.Connection.State != System.Data.ConnectionState.Open)
            {
                kadikontrol.Connection.Open();
            }
            SqlDataReader dr = kadikontrol.ExecuteReader();
            return dr.Read();
        }
        public static List<kullanici> kullaniciYetki(kullanici y)
        {
            List<kullanici> list = new List<kullanici>();
            SqlCommand komut = new SqlCommand($"Select * from kullanicis where ku_Adi='{y.ku_Adi}' and ku_Sifre='{y.ku_Sifre}'", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kullanici user = new kullanici();
                user.ku_ID = Convert.ToInt32(dr["ku_ID"]);
                user.ku_Adi = dr["ku_Adi"].ToString();
                user.ku_Sifre = dr["ku_Sifre"].ToString();
                user.ku_Yetki = Convert.ToBoolean(dr["ku_Yetki"]);
                list.Add(user);
            }
            dr.Close();
            return list;
        }

        public static void kullaniciSil(int bs)
        {
            SqlCommand sil = new SqlCommand("Delete from kullanicis where ku_ID = @k", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@k", bs);
            sil.ExecuteNonQuery();
        }

        public static void kullaniciGuncelle(kullanici kg)
        {
            SqlCommand gunc = new SqlCommand("Update kullanicis set ku_Adi=@a, ku_Sifre=@s, ku_Yetki=@y where ku_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", kg.ku_ID);
            gunc.Parameters.AddWithValue("@a", kg.ku_Adi);
            gunc.Parameters.AddWithValue("@s", kg.ku_Sifre);
            gunc.Parameters.AddWithValue("@y", kg.ku_Yetki);
            gunc.ExecuteNonQuery();

        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////BİRİM İŞLEMLERİ/////////////////////

        public static List<birim> birimListesi()
        {
            List<birim> birimListesi = new List<birim>();
            SqlCommand komut = new SqlCommand("select * from birims", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                birim birm = new birim();
                birm.b_ID = Convert.ToInt32(dr["b_ID"]);
                birm.b_Adi = dr["b_Adi"].ToString();
                birimListesi.Add(birm);
            }
            dr.Close();
            return birimListesi;
        }

        public static int birimEkle(birim be)
        {
            SqlCommand ekle = new SqlCommand("Insert into birims (b_Adi) values(@b)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@b", be.b_Adi);
            return ekle.ExecuteNonQuery();

        }

        public static void birimSil(int bs)
        {
            SqlCommand sil = new SqlCommand("Delete from birims where b_ID = @b", connect.db);
            SqlCommand sil2 = new SqlCommand("Delete from uruns where u_BirimID_b_ID = @b2", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@b", bs);
            sil2.Parameters.AddWithValue("@b2", bs);
            sil2.ExecuteNonQuery();
            sil.ExecuteNonQuery();
        }

        public static void birimGuncelle(birim bg)
        {
            SqlCommand gunc = new SqlCommand("Update birims set b_Adi=@a where b_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", bg.b_ID);
            gunc.Parameters.AddWithValue("@a", bg.b_Adi);
            gunc.ExecuteNonQuery();

        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*KATEGORİ İŞLEMLERİ*///////////////////////

        public static List<kategori> kategoriListesi()
        {
            List<kategori> kategoriListesi = new List<kategori>();
            SqlCommand komut = new SqlCommand("select * from kategoris", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kategori kate = new kategori();
                kate.k_ID = Convert.ToInt32(dr["k_ID"]);
                kate.k_Adi = dr["k_Adi"].ToString();
                kate.k_kdv = Convert.ToInt32(dr["k_kdv"]);
                kategoriListesi.Add(kate);
            }
            dr.Close();
            return kategoriListesi;
        }

        public static int kategoriEkle(kategori ke)
        {
            SqlCommand ekle = new SqlCommand("Insert into kategoris (k_Adi,k_kdv) values(@a,@k)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@a", ke.k_Adi);
            ekle.Parameters.AddWithValue("@k", ke.k_kdv);
            return ekle.ExecuteNonQuery();
        }

        public static void kategoriSil(int ki)
        {
            SqlCommand sil = new SqlCommand("Delete from kategoris where k_ID = @k", connect.db);
            SqlCommand sil2 = new SqlCommand("Delete from uruns where u_KategoriID_k_ID = @k2", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@k", ki);
            sil2.Parameters.AddWithValue("@k2", ki);
            sil2.ExecuteNonQuery();
            sil.ExecuteNonQuery();
        }

        public static void kategoriGuncelle(kategori kg)
        {
            SqlCommand gunc = new SqlCommand("Update kategoris set k_Adi=@a, k_kdv=@k where k_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", kg.k_ID);
            gunc.Parameters.AddWithValue("@a", kg.k_Adi);
            gunc.Parameters.AddWithValue("@k", kg.k_kdv);
            gunc.ExecuteNonQuery();

        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*MARKA İŞLEMLERİ*///////////////////////
        marka mark = new marka();
        public static List<marka> markaListesi()
        {
            List<marka> markaListesi = new List<marka>();
            SqlCommand komut = new SqlCommand("select * from markas", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                marka mark = new marka();
                mark.m_ID = Convert.ToInt32(dr["m_ID"]);
                mark.m_Adi = dr["m_Adi"].ToString();
                markaListesi.Add(mark);
            }
            dr.Close();
            return markaListesi;
        }

        public static int markaEkle(marka me)
        {
            SqlCommand ekle = new SqlCommand("Insert into markas (m_Adi) values(@m)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@m", me.m_Adi);
            return ekle.ExecuteNonQuery();
        }

        public static void markaSil(int mi)
        {
            SqlCommand sil = new SqlCommand("Delete from markas where m_ID = @m", connect.db);
            SqlCommand sil2 = new SqlCommand("Delete from uruns where u_MarkaID_m_ID = @m2", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@m", mi);
            sil2.Parameters.AddWithValue("@m2", mi);
            sil2.ExecuteNonQuery();
            sil.ExecuteNonQuery();
        }

        public static void markaGuncelle(marka mg)
        {
            SqlCommand gunc = new SqlCommand("Update markas set m_Adi=@a where m_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", mg.m_ID);
            gunc.Parameters.AddWithValue("@a", mg.m_Adi);
            gunc.ExecuteNonQuery();
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*TOPTANCI İŞLEMLERİ*///////////////////////
        toptanci toptan = new toptanci();
        public static List<toptanci> toptanciListesi()
        {
            List<toptanci> toptanciListesi = new List<toptanci>();
            SqlCommand komut = new SqlCommand("select * from toptancis", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                toptanci toptan = new toptanci();
                toptan.t_ID = Convert.ToInt32(dr["t_ID"]);
                toptan.t_Adi = dr["t_Adi"].ToString();
                toptan.t_Adres = dr["t_Adres"].ToString();
                toptan.t_Tel = dr["t_Tel"].ToString();
                toptanciListesi.Add(toptan);
            }
            dr.Close();
            return toptanciListesi;
        }

        public static int toptanciEkle(toptanci te)
        {
            SqlCommand ekle = new SqlCommand("Insert into toptancis (t_Adi,t_Adres,t_Tel) values(@a,@as,@t)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@a", te.t_Adi);
            ekle.Parameters.AddWithValue("@as", te.t_Adres);
            ekle.Parameters.AddWithValue("@t", te.t_Tel);
            return ekle.ExecuteNonQuery();
        }

        public static void toptanciSil(int ti)
        {
            SqlCommand sil = new SqlCommand("Delete from toptancis where t_ID = @t", connect.db);
            SqlCommand sil2 = new SqlCommand("Delete from uruns where u_ToptanciID_t_ID = @t2", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@t", ti);
            sil2.Parameters.AddWithValue("@t2", ti);
            sil2.ExecuteNonQuery();
            sil.ExecuteNonQuery();
        }

        public static void toptanciGuncelle(toptanci tg)
        {
            SqlCommand gunc = new SqlCommand("Update toptancis set t_Adi=@a, t_Adres=@as, t_Tel=@t where t_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", tg.t_ID);
            gunc.Parameters.AddWithValue("@a", tg.t_Adi);
            gunc.Parameters.AddWithValue("@as", tg.t_Adres);
            gunc.Parameters.AddWithValue("@t", tg.t_Tel);
            gunc.ExecuteNonQuery();
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////*MÜŞTERİ İŞLEMLERİ*///////////////////////
        musteri must = new musteri();
        public static List<musteri> musteriListesi()
        {
            List<musteri> musteriListesi = new List<musteri>();
            SqlCommand komut = new SqlCommand("select * from musteris", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                musteri must = new musteri();
                must.mu_ID = Convert.ToInt32(dr["mu_ID"]);
                must.mu_TC = dr["mu_TC"].ToString();
                must.mu_Adi = dr["mu_Adi"].ToString();
                must.mu_Adres = dr["mu_Adres"].ToString();
                must.mu_Tel = dr["mu_Tel"].ToString();
                musteriListesi.Add(must);
            }
            dr.Close();
            return musteriListesi;
        }

        public static int musteriEkle(musteri me)
        {
            SqlCommand ekle = new SqlCommand("Insert into musteris (mu_Adi,mu_TC,mu_Adres,mu_Tel) values(@ad,@tc,@as,@t)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@tc", me.mu_TC);
            ekle.Parameters.AddWithValue("@ad", me.mu_Adi);
            ekle.Parameters.AddWithValue("@as", me.mu_Adres);
            ekle.Parameters.AddWithValue("@t", me.mu_Tel);
            return ekle.ExecuteNonQuery();
        }

        public static void musteriSil(int mi)
        {
            SqlCommand sil = new SqlCommand("Delete from musteris where mu_ID = @t", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@t", mi);
            sil.ExecuteNonQuery();
        }

        public static void musteriGuncelle(musteri mg)
        {
            SqlCommand gunc = new SqlCommand("Update musteris set mu_Adi=@a, mu_TC=@tc, mu_Adres=@as, mu_Tel=@t where mu_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", mg.mu_ID);
            gunc.Parameters.AddWithValue("@tc", mg.mu_TC);
            gunc.Parameters.AddWithValue("@a", mg.mu_Adi);
            gunc.Parameters.AddWithValue("@as", mg.mu_Adres);
            gunc.Parameters.AddWithValue("@t", mg.mu_Tel);
            gunc.ExecuteNonQuery();
        }



        ///////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////ÜRÜN İŞLEMLERİ/////////////////////
        public static int urunEkle(urun ue)
        {
            SqlCommand ekle = new SqlCommand("Insert into uruns (u_Kod,u_Aciklama,u_SatisFiyat,u_AlisFiyat,u_Stok,u_BirimID_b_ID,u_KategoriID_k_ID,u_MarkaID_m_ID,u_ToptanciID_t_ID) values(@ko,@ac,@sf,@af,@st,@bi,@ki,@mi,@ti)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@ko", ue.u_Kod);
            ekle.Parameters.AddWithValue("@ac", ue.u_Aciklama);
            ekle.Parameters.AddWithValue("@sf", ue.u_SatisFiyat);
            ekle.Parameters.AddWithValue("@af", ue.u_AlisFiyat);
            ekle.Parameters.AddWithValue("@st", ue.u_Stok);
            ekle.Parameters.AddWithValue("@bi", ue.Birim);
            ekle.Parameters.AddWithValue("@ki", ue.Kategori);
            ekle.Parameters.AddWithValue("@mi", ue.Marka);
            ekle.Parameters.AddWithValue("@ti", ue.Toptanci);
            return ekle.ExecuteNonQuery();

        }

        public static int urunGuncelle(urun ug)
        {
            SqlCommand gunc = new SqlCommand("Update uruns set u_Kod=@ko, u_Aciklama=@ac, u_SatisFiyat=@sf, u_AlisFiyat=@af,  u_Stok=@st, u_BirimID_b_ID=@bi, u_KategoriID_k_ID=@ki, u_MarkaID_m_ID=@mi, u_ToptanciID_t_ID=@ti where u_ID=@i ", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", ug.u_ID);
            gunc.Parameters.AddWithValue("@ko", ug.u_Kod);
            gunc.Parameters.AddWithValue("@ac", ug.u_Aciklama);
            gunc.Parameters.AddWithValue("@sf", ug.u_SatisFiyat);
            gunc.Parameters.AddWithValue("@af", ug.u_AlisFiyat);
            gunc.Parameters.AddWithValue("@st", ug.u_Stok);
            gunc.Parameters.AddWithValue("@bi", ug.Birim);
            gunc.Parameters.AddWithValue("@ki", ug.Kategori);
            gunc.Parameters.AddWithValue("@mi", ug.Marka);
            gunc.Parameters.AddWithValue("@ti", ug.Toptanci);
            return gunc.ExecuteNonQuery();

        }

        public static string urunStok(int id)
        {
            urun urn = new urun();
            SqlCommand komut = new SqlCommand("select u_Stok from uruns where u_ID=@i", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@i", id);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            urn.u_Stok = Convert.ToInt32(dr["u_Stok"].ToString());
            dr.Close();
            return urn.u_Stok.ToString();
        }

        public static int urunStokGuncelle(urun ug)
        {
            SqlCommand gunc = new SqlCommand("Update uruns set u_Stok=@st where u_ID=@i ", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", ug.u_ID);
            gunc.Parameters.AddWithValue("@st", ug.u_Stok);
            return gunc.ExecuteNonQuery();

        }

        public static void urunSil(int ui)
        {
            SqlCommand sil = new SqlCommand("Delete from uruns where u_ID = @i", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@i", ui);
            sil.ExecuteNonQuery();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////zRapor İŞLEMLERİ/////////////////////

        public static List<zRapor> zRaporListele()
        {
            List<zRapor> zRaporListesi = new List<zRapor>();
            SqlCommand komut = new SqlCommand("select * from zRapors", connect.db);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                zRapor rapor = new zRapor();
                rapor.z_ID = Convert.ToInt32(dr["z_ID"]);
                rapor.z_Tarih = dr["z_Tarih"].ToString();
                rapor.z_krediToplam = Convert.ToDecimal(dr["z_krediToplam"].ToString());
                rapor.z_nakitToplam = Convert.ToDecimal(dr["z_nakitToplam"].ToString());
                rapor.z_cekToplam = Convert.ToDecimal(dr["z_cekToplam"].ToString());
                rapor.z_Ciro = Convert.ToDecimal(dr["z_Ciro"].ToString());
                zRaporListesi.Add(rapor);
            }
            dr.Close();
            return zRaporListesi;
        }

        public static int zRaporGuncelle(zRapor zg)
        {
            SqlCommand gunc = new SqlCommand("Update zRapors set z_Tarih=@t,z_krediToplam=@kt,z_nakitToplam=@nt,z_cekToplam=@ct,z_Ciro=@c where z_ID=@i", connect.db);
            if (gunc.Connection.State != System.Data.ConnectionState.Open)
            {
                gunc.Connection.Open();
            }
            gunc.Parameters.AddWithValue("@i", zg.z_ID);
            gunc.Parameters.AddWithValue("@t", zg.z_Tarih);
            gunc.Parameters.AddWithValue("@kt", zg.z_krediToplam);
            gunc.Parameters.AddWithValue("@nt", zg.z_nakitToplam);
            gunc.Parameters.AddWithValue("@ct", zg.z_cekToplam);
            gunc.Parameters.AddWithValue("@c", zg.z_Ciro);
            return gunc.ExecuteNonQuery();

        }

        public static void zRaporSil(int zi)
        {
            SqlCommand sil = new SqlCommand("Delete from zRapors where z_ID = @i", connect.db);
            if (sil.Connection.State != System.Data.ConnectionState.Open)
            {
                sil.Connection.Open();
            }
            sil.Parameters.AddWithValue("@i", zi);
            sil.ExecuteNonQuery();
        }

        public static int zRaporEkle(zRapor ze)
        {
            SqlCommand ekle = new SqlCommand("Insert into zRapors (z_Tarih,z_krediToplam,z_nakitToplam,z_cekToplam,z_Ciro) values(@t,@k,@n,@c,@ci)", connect.db);
            if (ekle.Connection.State != System.Data.ConnectionState.Open)
            {
                ekle.Connection.Open();
            }
            ekle.Parameters.AddWithValue("@t", ze.z_Tarih);
            ekle.Parameters.AddWithValue("@k", ze.z_krediToplam);
            ekle.Parameters.AddWithValue("@n", ze.z_nakitToplam);
            ekle.Parameters.AddWithValue("@c", ze.z_cekToplam);
            ekle.Parameters.AddWithValue("@ci", ze.z_Ciro);
            return ekle.ExecuteNonQuery();

        }
        public static bool zRaporKontrol(zRapor zk)
        {
            SqlCommand zkontrol = new SqlCommand($"select * from zRapors where z_Tarih='{zk.z_Tarih}'", connect.db);
            if (zkontrol.Connection.State != System.Data.ConnectionState.Open)
            {
                zkontrol.Connection.Open();
            }
            SqlDataReader dr = zkontrol.ExecuteReader();
            return dr.Read();
        }

    }
}
