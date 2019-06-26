using System;
using System.Web;
using System.Web.UI;

namespace CurrencyConverter
{

    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load()
        {
            if(this.IsPostBack == false )
            {
                Para1.InnerHtml = "Trying out <HTML> and &lt;ENCODING&gt;";
                Para2.InnerHtml = Server.HtmlEncode("Trying out the <HTML> and <ENCODING>");
            }
        }

        protected void ConverterPage_ServerClick(Object sender, EventArgs args)
        {
            Response.Redirect("converter.aspx");
        }

        protected void ImagePage_ServerClick(Object sender, EventArgs args)
        {
            Response.Redirect("ImageControl.aspx");
            //Server.Transfer("ImageControl.aspx");
        }

        protected void TochiWebsite_ServerClick(Object sender, EventArgs args)
        {
            Response.Redirect("http://tochukwu.xyz");
        }

        protected void EncodeAll_ServerClick(Object sender, EventArgs args)
        {
            Output1.InnerText = Server.HtmlDecode(Input1.Value);

            Output2.InnerHtml = Server.UrlEncode(Input2.Value);
        }
    }
}

/**
 * Server.Transfer() sends the user from one ASP.net Page to the other.
 * Unlike Response.Redirect() it does not involve the browser.
 * This may be faster but the URL of the user's browser does not change.
 * You can not use Server.Transfer() to jump to a non ASP.NET page.
 * 
 * Aside from Server.HtmlEncode we also have:
 * Server.HtmlDecode()
 * Server.UrlEncode()
 * Server.UrlDecode()
 */