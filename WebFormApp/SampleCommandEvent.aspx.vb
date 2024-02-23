Public Class SampleCommandEvent
    Inherits System.Web.UI.Page

    Private objBarang As New List(Of String)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objBarang.Add("Buku")
        objBarang.Add("Pensil")
        objBarang.Add("Pulpen")
        objBarang.Add("Tas")
        objBarang.Add("Penghapus")
    End Sub

    Protected Sub Page_PreRender() Handles Me.PreRender
        bltBarang.DataSource = objBarang
        bltBarang.DataBind()
    End Sub

    Protected Sub Cek_Command(sender As Object, e As CommandEventArgs)
        If e.CommandName = "Sort" Then
            Select Case e.CommandArgument.ToString()
                Case "Asc"
                    objBarang.Sort(AddressOf SortAsc)
                Case "Desc"
                    objBarang.Sort(AddressOf SortDesc)
            End Select
        End If
    End Sub

    Function SortDesc(x As String, y As String) As Integer
        Return String.Compare(x, y) * -1
    End Function

    Function SortAsc(x As String, y As String) As Integer
        Return String.Compare(x, y)
    End Function

End Class