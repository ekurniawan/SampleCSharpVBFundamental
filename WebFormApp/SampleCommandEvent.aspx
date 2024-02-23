<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleCommandEvent.aspx.vb" Inherits="WebFormApp.SampleCommandEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnUrutAsc" runat="server" Text="Urut Asc" CommandArgument="Asc"
                CommandName="Sort" OnCommand="Cek_Command" />&nbsp;&nbsp;
            <asp:Button ID="btnUrutDesc" runat="server"
                Text="Urut Desc" CommandArgument="Desc" CommandName="Sort"
                OnCommand="Cek_Command" />
            <br />
            <br />
            <asp:BulletedList ID="bltBarang" runat="server"
                BulletStyle="Numbered">
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
