<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SimpleCalc.aspx.vb" Inherits="WebFormApp.SimpleCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Operasi:</label>
            <asp:RadioButton ID="rdKurang" Text="Kurang" GroupName="operator" runat="server" />
            <asp:RadioButton ID="rdTambah" Text="Tambah" GroupName="operator" runat="server" /><br />
            <label for="txtBil1">Bil 1:</label>
            <asp:TextBox runat="server" ID="txtBil1" /><br />
            <label for="txtBil2">Bil 2:</label>
            <asp:TextBox runat="server" ID="txtBil2" /><br />
            <asp:Label ID="lblHasil" runat="server" /><br />
            <asp:Button ID="btnHitung" Text="Hitung" runat="server" OnClick="btnHitung_Click" />
            <hr />
            <asp:HyperLink NavigateUrl="https://detik.com" ID="hlDetik" Text="Detik" runat="server" />
        </div>
    </form>
</body>
</html>
