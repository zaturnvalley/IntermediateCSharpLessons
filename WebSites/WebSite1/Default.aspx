<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First Site</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h1>Hello World</h1>
		<asp:TextBox ID="TextBoxName" placeholder="Enter your name" runat="server"></asp:TextBox><br />
		<asp:Button ID="ButtonDisplay" onclick="ButtonDisplay_Click" runat="server" Text="Display" /><br />
		<asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
