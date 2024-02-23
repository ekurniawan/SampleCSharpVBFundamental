<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CrossPage.aspx.vb" Inherits="WebFormApp.CrossPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSearch" Text="Search:"
                runat="server" />
            <asp:TextBox ID="txtSearch" runat="server" />
            <asp:TextBox ID="txtFullName" runat="server" />
            <asp:Button ID="btnSearch" Text="Cari"
                PostBackUrl="CrossPageResult.aspx" runat="server" />
        </div>
    </form>
</body>
</html>
