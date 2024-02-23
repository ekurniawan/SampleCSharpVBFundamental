Public Class PanelKontrol
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub radio_CheckedChanged(sender As Object, e As EventArgs)
        If rdlOther.Checked Then
            pnlOther.Visible = True
        Else
            pnlOther.Visible = False
        End If
    End Sub

End Class