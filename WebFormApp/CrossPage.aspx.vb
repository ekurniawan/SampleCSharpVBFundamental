Public Class CrossPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.PreviousPage IsNot Nothing Then
            txtSearch.Text = TryCast(PreviousPage.FindControl("txtSearch"), TextBox).Text

        End If
    End Sub

End Class