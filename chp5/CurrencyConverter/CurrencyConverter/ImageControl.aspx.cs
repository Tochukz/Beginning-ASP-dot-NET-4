using System;
using System.Web;
using System.Web.UI;

namespace CurrencyConverter
{

    public partial class ImageControl : System.Web.UI.Page
    {
        protected void Image_ServerClick(Object obj, ImageClickEventArgs e)
        {
            MessageElem.InnerHtml = "You click at (" + e.X + "," + e.Y + ")";
        }
    }
}
