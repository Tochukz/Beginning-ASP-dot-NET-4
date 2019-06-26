<%@ Page Language="C#" Inherits="CurrencyConverter.ImageControl" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>ImageControl</title>
</head>
<body>
	<form id="form1" runat="server">
        <p>Click any part of the image to see it's coordinated below</p>
        <input type="image" id="MealImage" src="images/meal.png" OnServerClick="Image_ServerClick" runat="server" />
        <p id="MessageElem" runat="server" />
	</form>
</body>
</html>
