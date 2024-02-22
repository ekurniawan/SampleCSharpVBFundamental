Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Transactions
Imports MyInterface

Public Class OrderTransDAL
    Implements IOrderTrans

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        conn = New SqlConnection(ConfigurationManager.AppSettings.Get("MyConnectionString"))
    End Sub

    Public Sub OrderTransProcess() Implements IOrderTrans.OrderTransProcess
        Using trans As New TransactionScope
            Try

                trans.Complete()
            Catch ex As Exception

            End Try
        End Using
    End Sub
End Class
