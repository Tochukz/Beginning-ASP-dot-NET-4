<%@ Application Inherits="CurrencyConverter.Global" %>

<script language="c#" runat="server">
  protected void Application_EndRequest(object sender, EventArgs args)
  {
    //This string passed to Write() will appear as the footer of every page.
    Response.Write("<hr /> This Page was server at " + DateTime.Now.ToString());
  }
</script>