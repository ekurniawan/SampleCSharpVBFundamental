<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebFormApp._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtHello">Enter your name:</label>
            <asp:TextBox ID="txtHello" runat="server" />
            <br />
            <asp:Label ID="lblResult" runat="server" /><br />
            <asp:Button ID="btnHello" runat="server" Text="Hello ASP" OnClick="btnHello_Click" />
            <hr />

            <label for="txtUsername">Username:</label>
            <asp:TextBox runat="server" ID="txtUsername" /><br />
            <label for="txtPassword">Password:</label>
            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" /><br />
            <label for="txtEmail">Email:</label>
            <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" /><br />
            <asp:Button runat="server" ID="btnSubmit" Text="Submit" />
        </div>
    </form>
</body>
</html>
