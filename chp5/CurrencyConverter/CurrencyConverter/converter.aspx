<%@ Page Language="C#" Inherits="CurrencyConverter.converter" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>converter</title>
</head>
<body>
	<form id="form1" runat="server">
       <div>
        Converter: 
        <input type="text" id="US" runat="server" /> &nbsp; 
        U.S. dollars to 
        <select id="Currency" runat="server" />
        <br /> <br />
        <input type="submit" value="OK" id="Convert"  OnServerClick="Convert_ServerClick" runat="server" />
        <input type="submit" value="Show Graph" id="ShowGraph"  OnServerClick="ShowGraph_ServerClick" runat="server" />                         
        <br /> <br />
        <img id="Graph" src="" alt="Currency Graph" runat="server" />
        <p  id="Result" runat="server"></p>
      </div>        
	</form>
</body>
</html>
