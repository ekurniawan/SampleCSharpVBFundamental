Public Class SampleAutoPostBack
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        lblSearch.Text = txtSearch.Text
    End Sub
End Class