<%@ Page Language="C#" Inherits="CurrencyConverter.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
        <h2>Working with HTML Server Controls</h2>       
            
        <button OnServerCLick="ConverterPage_ServerClick" runat="server">Converter Page</button> 
        <button OnServerClick="ImagePage_ServerClick" runat="server">Image Page</button>
        <button OnServerClick="TochiWebsite_ServerClick" runat="server">Tochi Website</button>
       <br /><br />
        <p id="Para1" runat="server"></p>
        <p id="Para2" runat="server"></p>
                
        Enter Html Encoded charaters to see Decoded:
        <input type="text" id="Input1" runat="server"> 
        <span id="Output1" runat="server"></span>
        <br /><br />
        Enter Url too see Encoded URL:
        <input type="text" id="Input2" runat="server"> 
        <span id="Output2" runat="server"></span>
        
        <br /><br />
        <input type="submit" OnServerClick="EncodeAll_ServerClick" runat="server"/>
	</form>
</body>
</html>
