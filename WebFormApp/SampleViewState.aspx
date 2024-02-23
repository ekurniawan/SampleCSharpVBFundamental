<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleViewState.aspx.vb" Inherits="WebFormApp.SampleViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Password:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Restore" />
        </div>
    </form>
</body>
</html>
