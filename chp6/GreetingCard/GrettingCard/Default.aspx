<%@ Page Language="C#" Inherits="GreetingCard.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
          <!-- The Controls -->
          Choose  a background color: <br />
          <asp:DropDownList id="lstBackColor" Width="194px" Height="22px" OnSelectedIndexChanged="ReGenerateCard" AutoPostBack="true" runat="server" /><br /><br />
          
          Choose a font:<br />          
          <asp:DropDownList id="lstFontName" Width="194px" Height="22px" OnSelectedIndexChanged="ReGenerateCard" AutoPostBack="true" runat="server" /><br /><br />
            
          Specify a numeric font size: <br />
          <asp:TextBox id="txtFontSize" Text="15" runat="server" OnTextChanged="ReGenerateCard" AutoPostBack="true" /><br /><br />
          
          Choose a border style: <br />
          <asp:RadioButtonList id="lstBorder" Width="177px" Height="59px" OnSelectedIndexChanged="ReGenerateCard" AutoPostBack="true" runat="server" /><br /><br />
                
          <asp:CheckBox id="chkPicture" Text="Add the Default Picture" OnCheckedChanged="ReGenerateCard" AutoPostBack="true" runat="server"></asp:CheckBox><br /><br />
           
          Enter the greeting text below:<br />
          <asp:TextBox id="txtGreeting" Width="240px" Height="85px" TextMode="MultiLine" OnTextChanged="ReGenerateCard" AutoPostBack="true" runat="server" /><br /><br />
         
          <asp:Button id="cmdUpdate" Width="71px" Height="24px" Text="Update" OnClick="CmdUpdate_Click" runat="server" />
        </div>          
        
        <!--The Greeting Card -->
        <asp:Panel id="pnlCard" Width="399px" Height="481px" HorizontalAlign="Center" Style="POSITION: absolute; TOP: 16px; LEFT: 313px;" runat="server"> <br />&nbsp;
          <asp:Label id="lblGreeting" Width="256px" Height="150px" runat="server" /><br /><br /><br />
          <asp:Image id="imgDefault" Width="212px" Height="160px" runat="server" />
         </asp:Panel>   
         
	</form>
</body>
</html>
