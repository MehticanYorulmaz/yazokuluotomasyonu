using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Yaz_Okulu_Otomasyonu
{
    public class SQLHelper
    {
        public static string _baglantiAdresi = "Server=DESKTOP-KS9RB2B;Database=Yaz-Okulu;User Id=sa;Password=Yorulmaz981404;";

        public static bool GirisYap_Ogretmen(string TcKimlikNo,string sifre)
        {
            DataTable sonuclar = new DataTable();
            using (SqlConnection sqlBaglantisi = new SqlConnection(_baglantiAdresi))
            {
                string sorgu = "select * from Ogretim_Uyesi where TcKimlik='" + TcKimlikNo + "' and Sifre='" + sifre + "'";
                using (SqlCommand sqlKomutu =new SqlCommand(sorgu,sqlBaglantisi))
                {
                    sqlBaglantisi.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sqlKomutu);
                    da.Fill(sonuclar);
                    if (sonuclar.Rows.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public  static bool GirisYap_Ogrenci(string TcKimlikNo,string Sifre)
        {
            DataTable sonuclar = new DataTable();
            using (SqlConnection sqlBaglantisi = new SqlConnection(_baglantiAdresi))
            {
                string sorgu = "select * from Ogrenci where TcKimlik='" + TcKimlikNo + "' and Sifre='" + Sifre + "'";
                using (SqlCommand sqlKomutu = new SqlCommand(sorgu, sqlBaglantisi))
                {
                    sqlBaglantisi.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sqlKomutu);
                    da.Fill(sonuclar);
                    if (sonuclar.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
       

    }
}