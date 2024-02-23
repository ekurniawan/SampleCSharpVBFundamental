Public Class SampleViewState
    Inherits System.Web.UI.Page

    'Dim a, b As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        ViewState("name") = TextBox1.Text
        ViewState("password") = TextBox2.Text

        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        TextBox1.Text = ViewState("name")
        TextBox2.Text = ViewState("password")
    End Sub
End Class