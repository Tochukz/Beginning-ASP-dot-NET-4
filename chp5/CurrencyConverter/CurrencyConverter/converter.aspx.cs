using System;
using System.Web;
using System.Web.UI;
using System.Linq;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Globalization;

namespace CurrencyConverter
{

    public partial class converter : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Currency.Items.Add(new ListItem("Euro", "0.85"));
                Currency.Items.Add(new ListItem("Japanese Yen", "100.33"));
                Currency.Items.Add(new ListItem("Canadian Dollar", "1.2"));

                Graph.Visible = false;
            }
        }

        protected void Convert_ServerClick(object sender, EventArgs e)
        {
            //decimal USAmount = Decimal.Parse(US.Value);

            decimal oldAmount;
            bool success = Decimal.TryParse(US.Value, out oldAmount);

            if (success == true && oldAmount > 0)
            {
                ListItemCollection selectList = Currency.Items; 
                int selectedIndex = Currency.SelectedIndex; 
                ListItem selectedItem = selectList[selectedIndex];

                NumberStyles numberStyles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                CultureInfo provider = new CultureInfo("en-US");

                decimal convertionFactor = Decimal.Parse(selectedItem.Value, numberStyles, provider);
                ListItem item = Currency.Items[Currency.SelectedIndex];
                decimal newAmount = oldAmount * convertionFactor;
                Result.InnerText = oldAmount.ToString() + " U.S dollars = ";
                Result.InnerText += newAmount.ToString() + " " + item.Text;

                Graph.Src = "images/pic" + Currency.SelectedIndex.ToString() + ".png";

                Result.Style["color"] = "Black";
            }
            else
            {
                Result.InnerText = "The input is not a valid number";
                Result.Style["color"] = "Red";
            }

        }

        protected void ShowGraph_ServerClick(Object sender, EventArgs e)
        {
            Graph.Src = "images/pic" + Currency.SelectedIndex.ToString() + ".png";
            Graph.Visible = true;
        }
    }
}
