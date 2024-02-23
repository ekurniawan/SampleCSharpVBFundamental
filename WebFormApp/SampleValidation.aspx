<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleValidation.aspx.vb" Inherits="WebFormApp.SampleValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtUsername">Username :</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required"
                ForeColor="Red"></asp:RequiredFieldValidator><br />
            <label for="txtPassword">Password :</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required"
                ForeColor="Red"></asp:RequiredFieldValidator><br />
            <label for="txtRepassword">Repassword :</label>
            <asp:TextBox ID="txtRepassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                runat="server" ControlToValidate="txtRepassword" ErrorMessage="Repassword is required"
                ForeColor="Red"></asp:RequiredFieldValidator><br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtRepassword"
                ControlToCompare="txtPassword" ErrorMessage="Password and Repassword must be same"
                ForeColor="Red"></asp:CompareValidator><br />
            <label for="txtEmail">Email :</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required"
                ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email"
                ForeColor="Red" ValidationExpression="^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$">
            </asp:RegularExpressionValidator><br />

            Masukan Nim :<asp:TextBox ID="txtNim" runat="server" />
            <asp:CustomValidator ID="cvNim" runat="server"
                ErrorMessage="NIM harus 8 Karakter"
                ControlToValidate="txtNim"
                OnServerValidate="cvNim_ServerValidate" /><br />
          
            <asp:ValidationSummary runat="server" ForeColor="Red" HeaderText="Error Message"
                ShowMessageBox="false" ShowSummary="true" />

            <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
        </div>
    </form>
</body>
</html>
