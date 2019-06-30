using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace WebControlApp
{

    public partial class Default : System.Web.UI.Page
    {
       protected void Page_Load()
       {
           if(this.IsPostBack == false)
           {
                SetHeightAndWidths();
                SetColors();
                FormatLines();
                OverrideDefaultFocus();
            }
        }

        private void SetHeightAndWidths()
        {
            Pan2.Height = Unit.Pixel(100);
            Pan2.Width = Unit.Percentage(50);

            Pan3.Height = new Unit(100, UnitType.Pixel);
            Pan3.Width = new Unit(50, UnitType.Percentage);

            Lable2.BorderStyle = BorderStyle.Dashed;
        }

        private void SetColors()
        {
            //Color from ARGB value
            int trans = 255, red = 167, green = 76, blue = 199;
            Input3.ForeColor = Color.FromArgb(trans, red, green, blue);

            //Color from ASP.NET
            Input4.ForeColor = Color.Crimson;

            //Color from HTML
            Input5.ForeColor = ColorTranslator.FromHtml("Blue");

        }

        private void FormatLines()
        {
            Line2.Font.Size = FontUnit.Small;
            Line3.Font.Size = FontUnit.Point(14);
            
            Line1.Font.Name = "Verdana";
            Line2.Font.Bold = true;
            Line5.Font.Names = new string[] { "Tahoma", "Verdana", "Arial" };
        }

        private void OverrideDefaultFocus()
        {
            Input5.Focus();
        }

        protected void Go_ServerClick(Object sender, EventArgs args)
        {
            GoButton.Text = "Now Going...";
        }
    }
}
