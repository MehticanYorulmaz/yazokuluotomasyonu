using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Otomasyonu
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["kullanici_Turu"]!="Ogretmen"|| Session["kullanici_Turu"] != "Ogrenci")
            {
               

                if (Session["kullanici_Turu"]=="Ogretmen")
                {
                    lblYazi.Text = "Öğretmen Giriş Yaptı";
                }
                else if (Session["kullanici_Turu"] == "Ogrenci")
                {
                    lblYazi.Text = "Öğrenci Giriş Yaptı";
                }

            }

            else
            {
                Response.Redirect("index.aspx");
            }



        }
    }
}