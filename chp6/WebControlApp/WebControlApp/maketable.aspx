<%@ Page Language="C#" Inherits="WebControlApp.maketable" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>maketable</title>
</head>
<body>
	<form id="form1" runat="server">
      <div>
        <asp:Label Text="A Sample 2x2 Table" runat="server" /><br />
        <asp:Table runat="server" BorderWidth="1">
          <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderWidth="1">PHP</asp:TableCell>               
            <asp:TableCell runat="server" BorderWidth="1">C#</asp:TableCell>
          </asp:TableRow>
          <asp:TableRow runat="server">
            <asp:TableCell runat="server" BorderWidth="1">JavaScript</asp:TableCell>
            <asp:TableCell runat="server" BorderWidth="1">Java</asp:TableCell>
          </asp:TableRow>
        </asp:Table>
      </div>
       <br /> <br />
      Rows: &nbsp;
      <asp:TextBox id="txtRows" runat="server" /> &nbsp;
      Cols: &nbsp;
      <asp:TextBox id="txtCols" runat="server"/> <br />     
      <asp:CheckBox id="chkBorder" Text="Add Borders in cells:" runat="server" /> <br /><br />
      <asp:Button  id="cmdMake" Text="Make Table" OnClick="Make_Click" runat="server" /> <br />
       
      <asp:Table id="tbl" runat="server" />
	</form>
</body>
</html>
