<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SampleUploadImage.aspx.vb" Inherits="WebFormApp.SampleUploadImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Image</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="fpGambar">MAsukan Gambar :</label>
            <asp:FileUpload ID="fpGambar" runat="server" />
            <asp:Button ID="btnUpload" runat="server" OnClick="btnUpload_Click"
                Text="Upload" /><br />
            <asp:Label ID="lblStatus" runat="server" />
            <hr />
            <asp:DataList ID="dlGambar" runat="server" RepeatColumns="3">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server"
                        ImageUrl='<%# Eval("Name", "~/Images/{0}") %>' Style="width: 200px;padding:5px;margin:10px;" />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
