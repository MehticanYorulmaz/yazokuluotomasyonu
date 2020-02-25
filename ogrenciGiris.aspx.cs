using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Otomasyonu
{
    public partial class ogrenciGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            bool sonuc = SQLHelper.GirisYap_Ogrenci(txtTcKimlikNo.Text, txtSifre.Text);

            if (sonuc)
            {
                Session.Add("kullanici_Turu", "Ogrenci");
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Label1.Text = "Hatalı Giriş";
            }
        }
    }
}