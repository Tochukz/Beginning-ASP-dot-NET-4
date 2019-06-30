using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlApp
{

    public partial class TrackEvents : System.Web.UI.Page
    {
        protected void Page_Load(Object sender, EventArgs args)
        {
            Log("<< Page_Load >>");
          
        }

        protected void Page_PreRender(object sender, EventArgs args)
        {
            //When the Page.PreRender evnet ooccurs, it is too late to change the list.
            Log("Page_PreRender");
        }

        protected void Input_Change(object sender, EventArgs args)
        {
            string ctrlName = ((Control)sender).ID;
            Log(ctrlName + "Changed");
        }

        private void Log(string entry)
        {
            //This is not working at the moment. DEbug later.

            //lst.Items.Add(entry);
            //Select the last item to scroll the list so the most recent entries are visible.
            //lst.SelectedIndex = lst.Items.Count - 1;
        }
    }
}
