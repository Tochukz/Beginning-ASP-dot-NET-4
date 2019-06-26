using System;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;

namespace CurrencyConverter
{

    public partial class ShowSettings : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs args)
        {
            if (this.IsPostBack == false)
            {
                AppName.InnerText = WebConfigurationManager.AppSettings["appName"];
                AppAuthor.InnerText = WebConfigurationManager.AppSettings["appAuthor"];
            }
        }
    }
}
