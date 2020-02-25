using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Otomasyonu
{
    public partial class ogretmenGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["cerezim"] !=null)
            {
                HttpCookie kayitlicerez = Request.Cookies["cerezim"];
            }
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            bool sonuc = SQLHelper.GirisYap_Ogretmen(txtTcKimlikNo.Text, txtSifre.Text);

            if (sonuc)
            {
                Session.Add("kullanici_Turu", "Ogretmen");
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Label1.Text = "Hatalı Giriş";
            }
        }
    }
}