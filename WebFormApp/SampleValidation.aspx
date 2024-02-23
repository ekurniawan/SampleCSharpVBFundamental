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
            <asp:CompareValidator ID="CompareValidator1" runat="server" controltovalidate="txtRepassword" 
                controltocompare="txtPassword" errormessage="Password and Repassword must be same" 
                forecolor="Red"></asp:CompareValidator><br />

            <asp:ValidationSummary runat="server" ForeColor="Red" HeaderText="Error Message" 
                ShowMessageBox="false" ShowSummary="true" />

            <asp:Button ID="btnSubmit" Text="Submit" runat="server" />
        </div>
    </form>
</body>
</html>
