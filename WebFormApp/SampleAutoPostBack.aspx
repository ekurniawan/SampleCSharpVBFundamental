<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleAutoPostBack.aspx.vb" Inherits="WebFormApp.SampleAutoPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contoh AutoPostBack</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Masukan Keyword :
            <asp:TextBox ID="txtSearch"
                runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged" /><hr />
            <asp:Label ID="lblSearch" runat="server"
                Text="" />
        </div>
    </form>
</body>
</html>
