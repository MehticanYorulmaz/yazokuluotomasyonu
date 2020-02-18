using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yaz_Okulu_Otomasyonu
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOgretmen_Click(object sender, EventArgs e)
        {
            Response.Redirect("ogretmengiris.aspx");
        }

        protected void btnOgrenci_Click(object sender, EventArgs e)
        {
            Response.Redirect("ogrencigiris.aspx");
        }
    }
}