Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnHello_Click(sender As Object, e As EventArgs)
        lblResult.Text = "Hello, " & txtHello.Text
    End Sub
End Class