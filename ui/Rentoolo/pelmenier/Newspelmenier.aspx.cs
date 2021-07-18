using Rentoolo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rentoolo.pelmenier
{
    public partial class Newspelmenier : System.Web.UI.Page
    {
        public List<Rentoolo.Model.Newspelmenier> ListNews;

        protected void Page_Load(object sender, EventArgs e)
        {
            ListNews = DataHelperPelmenier.GetActiveNews();
        }
    }
}