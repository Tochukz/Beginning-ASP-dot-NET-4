using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlApp
{

    public partial class ShowListControls : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs args)
        {
            if (!this.IsPostBack)
            {
                AddItemsToCheckList();
                AddItemToBulletedList();
            }
        }

        protected void cmdOK_Click(object sender, EventArgs args)
        {
            lblResult.Text = "You chose:<br >";
            foreach(ListItem item in chklst.Items)
            {
                if(item.Selected == true)
                {
                    lblResult.Text += item.Value + "<br />";
                }
            }
        }

        protected void BulletListStyle(object sender, BulletedListEventArgs args)
        {
            lblShowStyle.Text = bltLst.Items[args.Index].Text;
        }

        private void AddItemsToCheckList()
        {
            chklst.Items.Add("PHP");
            chklst.Items.Add("Rust");
            chklst.Items.Add("Dart");
            chklst.Items.Add("C#");
            chklst.Items.Add("JavaScript");
        }

        private void AddItemToBulletedList()
        {
            bltLst.Items.Add("NotSet");
            bltLst.Items.Add("Numbered");
            bltLst.Items.Add("LowerAlpha");
            bltLst.Items.Add("UpperAlpha");
            bltLst.Items.Add("LowerRoma");
            bltLst.Items.Add("UpperRoman");
            bltLst.Items.Add("Disc");
            bltLst.Items.Add("Circle");
            bltLst.Items.Add("Square");
            bltLst.Items.Add("CustomImage");
        }
    }
}
