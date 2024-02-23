Public Class SimpleCalc
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnHitung_Click(sender As Object, e As EventArgs)
        If rdTambah.Checked Then
            lblHasil.Text = CInt(txtBil1.Text) + CInt(txtBil2.Text)
        Else
            lblHasil.Text = CInt(txtBil1.Text) - CInt(txtBil2.Text)
        End If
    End Sub
End Class