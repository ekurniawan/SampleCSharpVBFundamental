Public Class CrossPageResult
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.PreviousPage IsNot Nothing Then
            Dim fullname = TryCast(PreviousPage.FindControl("txtFullName"), TextBox).Text

            lblSearch.Text = TryCast(PreviousPage.FindControl("txtSearch"), TextBox).Text & " " & fullname
        End If
    End Sub

End Class