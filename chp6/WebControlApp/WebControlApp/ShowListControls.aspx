<%@ Page Language="C#" Inherits="WebControlApp.ShowListControls" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>ShowListControls</title>
</head>
<body>
	<form id="form1" runat="server">
       <div>
         Choose your programming languages:<br /><br />
         <asp:CheckBoxList id="chklst" runat="server" /><br/><br />
         <asp:Button id="cmdOK" Text="OK" OnClick="cmdOK_Click" runat="server" />
         <br /><br />
         <asp:Label id="lblResult" runat="server" />
         <br /> <br />
          
         Click on any item to see it below: <br />
         <asp:BulletedList id="bltLst" BulletStyle="Numbered" DisplayMode="LinkButton" OnClick="BulletListStyle" runat="server" />                
         You clicked:
         <asp:Label id="lblShowStyle" runat="server" />
       </div>
	</form>
</body>
</html>
