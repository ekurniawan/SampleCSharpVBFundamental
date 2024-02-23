<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PanelKontrol.aspx.vb" Inherits="WebFormApp.PanelKontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Bahasa pemrograman favorit anda:
            <br />
            <br />
            <asp:RadioButton ID="rdlVisualBasic"
                GroupName="language" Text="Visual Basic" AutoPostBack="true"
                runat="server" OnCheckedChanged="radio_CheckedChanged" />
            <br />
            <br />
            <asp:RadioButton
                ID="rdlCSharp" GroupName="language" Text="C#" AutoPostBack="true"
                runat="server" OnCheckedChanged="radio_CheckedChanged" />
            <br />
            <br />
            <asp:RadioButton ID="rdlOther" GroupName="language" AutoPostBack="true"
                Text="Other Language" runat="server" OnCheckedChanged="radio_CheckedChanged" />
            <br />
            <asp:Panel ID="pnlOther" Visible="false"
                runat="server">
                <asp:Label ID="lblOther" Text="Bahasa yg lain:"
                    AssociatedControlID="txtOther" runat="server" />
                <asp:TextBox ID="txtOther" runat="server" />
            </asp:Panel>
            <br />
            <br />
            <asp:Button ID="btnSubmit" Text="Submit"
                runat="server" />
        </div>
    </form>
</body>
</html>
