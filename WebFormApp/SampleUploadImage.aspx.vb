Imports System.IO

Public Class SampleUploadImage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Page_PreRender() Handles Me.PreRender
        Dim dir As New DirectoryInfo(Server.MapPath("~/Images/"))
        dlGambar.DataSource = dir.GetFiles()
        dlGambar.DataBind()
    End Sub

    Function CekFileExtension(ByVal fileName As String) As Boolean
        Dim ext As String = System.IO.Path.GetExtension(fileName)
        Select Case ext.ToLower()
            Case ".jpg", ".jpeg", ".png", ".gif"
                Return True
            Case Else
                Return False
        End Select
    End Function

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs)
        If fpGambar.HasFiles Then
            If CekFileExtension(fpGambar.FileName) Then
                Dim path As String = Server.MapPath("~/Images/")
                Dim fileName As String = System.IO.Path.GetFileName(fpGambar.FileName)
                fpGambar.SaveAs(path & Guid.NewGuid.ToString & "-" & fileName)
                lblStatus.Text = "File berhasil diupload"
            Else
                lblStatus.Text = "File harus berupa gambar"
            End If
        Else
            lblStatus.Text = "Pilih file terlebih dahulu"
        End If
    End Sub
End Class