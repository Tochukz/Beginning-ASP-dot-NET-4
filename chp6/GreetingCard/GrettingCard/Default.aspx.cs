using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

namespace GreetingCard
{

    public partial class Default : System.Web.UI.Page
    {
      protected void Page_Load(object sender, EventArgs args)
      {
            if (!this.IsPostBack)
            {
                CreateFontList();
                CreateColorList();
                CreateBorderList();

                lstBorder.SelectedIndex = 0;
                imgDefault.ImageUrl = "images/defaultpic.png";
            }

        }

        protected void CmdUpdate_Click(Object sender, EventArgs args)
        {
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
            if (Int32.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size = FontUnit.Point(Int32.Parse(txtFontSize.Text));
            }

            //int borderValue = Int32.Parse(lstBorder.SelectedItem.Value);
            //pnlCard.BorderStyle = (BorderStyle)borderValue;
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(lstBorder.SelectedItem.Text);

            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
            lblGreeting.Text = txtGreeting.Text;
        }

        protected void ReGenerateCard(object sender, EventArgs args)
        {
            CmdUpdate_Click(sender, args);
        }

        private void CreateFontList()
        {
            //string[] fontNames = { "Times New Roman", "Arial", "Verdana", "Tahoma" };
            InstalledFontCollection fontNames = new InstalledFontCollection();
            foreach (FontFamily fontFamily in fontNames.Families)
            {
                lstFontName.Items.Add(fontFamily.Name);
            }

        }

        private void CreateColorList()
        {
            /*
              string[] colors = { "White", "Red", "Green", "Blue", "Yelow" };
              foreach (string color in colors)
              {
                  lstBackColor.Items.Add(color);
              }
              */
            string[] colors = Enum.GetNames(typeof(KnownColor));
            lstBackColor.DataSource = colors;
            lstBackColor.DataBind();
           
        }

        private void CreateBorderList()
        {
            /*
            //Set border style options by adding a series of ListItem objects
            ListItem item = new ListItem
            {
                Text = BorderStyle.None.ToString(), // The item text indicates the name of the option.
                Value = ((int)BorderStyle.None).ToString() // The item value records the corresponding integer from the enumeration. To obtain this value, you
                                                           // must cast the enumeration value to an integer, and then convert the number to a string so it can be placed in the HTML page.
            };
            lstBorder.Items.Add(item);

            // Now repeat the process for two other border styles.
            item = new ListItem
            {
                Text = BorderStyle.Double.ToString(),
                Value = ((int)BorderStyle.Double).ToString()
            };
            lstBorder.Items.Add(item);

            item = new ListItem
            {
                Text = BorderStyle.Solid.ToString(),
                Value = ((int)BorderStyle.Solid).ToString()
            };
            lstBorder.Items.Add(item);
            */

            string[] borderStyles = Enum.GetNames(typeof(BorderStyle));
            lstBorder.DataSource = borderStyles;
            lstBorder.DataBind();
        }
    }
}


/**
 * TypeConverter Class
 * A TypeConverter is a special class that is able to convert from a specialized type (in this case, the BorderStyle enumeration) to a simpler type (such as a string), and vice versa.
 * To access this class, you need to import the System.ComponentModel namespace:
 */
