Public Class SampleValidation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cvNim_ServerValidate(source As Object, args As ServerValidateEventArgs)
        If args.Value.Length = 8 Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If
    End Sub
End Class