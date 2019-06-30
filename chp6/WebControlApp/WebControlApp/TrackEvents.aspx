<%@ Page Language="C#" Inherits="WebControlApp.TrackEvents" EnableEventValidation="false" CodeFile="TrackEvents.aspx.cs"%>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>TrackEvents</title>
</head>
<body>
	<form id="form1" runat="server">
        <h1>Controls being monitored for change events:</h1>
        <asp:TextBox id="txt" OnTextChanged="Input_Change" AutoPostBack="true" runat="server" />
        <br /><br />
        <asp:CheckBox id="chk" OnCheckedChanged="Input_Change" AutoPostBack="true" runat="server" />
        <br /><br />
        <asp:RadioButton id="opt1" GroupName="Sample" OnCheckedChanged="Input_Change" AutoPostBack="true" runat="server" />
        <asp:RadionButton id="opt2" GroupName="Sample" OnCheckedChanged="Input_Change" AutoPostBack="true" runat="server" />
            
        <h1>List of events: </h1>
        <asp:ListBox id="lst"  Width="355px" Height="305px" runat="server" />
        <br /><br /><br />                               
    </form>
</body>
</html>
