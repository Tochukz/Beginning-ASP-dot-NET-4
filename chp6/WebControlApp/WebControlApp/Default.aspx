<%@ Page Language="C#" Inherits="WebControlApp.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server" DefaultFocus="Input3" DefaultButton="GoButton">
        <div>        
        <asp:HyperLink Text="Go to ListControl Page" NavigateUrl="ShowListControls.aspx" runat="server"></asp:HyperLink> &nbsp;      
        <asp:HyperLink Text="Go to Table Page" NavigateUrl="maketable.aspx" runat="server"></asp:HyperLink> &nbsp; 
        <asp:HyperLink Text="Go To EventTracker Page" NavigateUrl="TrackEvents.aspx" runat="server"></asp:HyperLink>
        <br />  <br />
		<asp:TextBox id="TextSpace" TextMode="MultiLine" Text="So much to learn" BackColor="AliceBlue" ForeColor="Blue" ReadOnly="true" Enabled="false" Rows="5" Columns="40" runat="server" /> 
        
        <asp:Panel id="Pan1" Height="100px" width="50%" Text="Pane 1" runat="server">
          <p>Panel 1</p>
        </asp:Panel>
        <asp:Panel id="Pan2" runat="server">
           <p>Panel 2</p>
        </asp:Panel>
        <asp:Panel id="Pan3" runat="server"> 
           <p>Panel 3</p>
        </asp:Panel>
            
        <asp:Label id="Lable1" BorderStyle="Dashed" Text="Border Style in Markup" runat="server" /> <br />
        <asp:Label id="Lable2" Text="Border Style in Code" runat="server" /> <br />
            
        <asp:TextBox id="Input1" Text="Input 1" ForeColor="Brown" TextMode="SingleLine" runat="server" /> <br />
        <asp:TextBox id="Input2" Text="Input 2" ForeColor="#ff50ff" runat="server" /> <br />
        <asp:TextBox id="Input3" Text="R40,000" runat="server" /> <br />
        <asp:TextBox id="Input4" Text="Input 4" runat="server" /> <br />
        <asp:TextBox id="Input5" Text=" $45,000 + Health Care + Flexi" runat="server" /> <br />
                
        <asp:Label id="Line1" Font-Size="40" Text="Formated Line1" runat="server" /> <br />
        <asp:Label id="Line2" Text="Formated Line2" runat="server" /> <br />
        <asp:Label id="Line3" Text="Formated Line1" runat="server" /> <br />
        <asp:Label id="Line4" Font-Names="Arial,Verdana,Tahoma" Text="Formated Line4" runat="server" /> <br />
        <asp:Label id="Line5" Font-Size="Large" Text="Formated Line5" runat="server" /> <br />
                
        <asp:Button id="GoButton" Text="Go" runat="server" OnServerClick="Go_ServerClick"/>
       </div>
   </form>
</body>
</html>
