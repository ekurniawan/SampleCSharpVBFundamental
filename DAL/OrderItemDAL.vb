Imports System.Configuration
Imports System.Data.SqlClient
Imports BO
Imports MyInterface

Public Class OrderItemDAL
    Implements IOrderItem

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        conn = New SqlConnection(ConfigurationManager.AppSettings.Get("MyConnectionString"))
    End Sub

    Public Function Create(obj As OrderItem) As Integer Implements ICrud(Of OrderItem).Create
        Try
            Dim strSql = "INSERT INTO [Orders].[OrderItems] ([OrderID],[StockID],[Quantity],[Discount]) 
            VALUES (@OrderID,@StockID,@Quantity,@Discount)"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@OrderID", obj.OrderID)
            cmd.Parameters.AddWithValue("@StockID", obj.StockID)
            cmd.Parameters.AddWithValue("@Quantity", obj.Quantity)
            cmd.Parameters.AddWithValue("@Discount", obj.Discount)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery()
            If result <> 1 Then
                Throw New ArgumentException("OrderItem not created")
            End If
            Return result
        Catch sqlex As SqlException
            Throw New ArgumentException(sqlex.Message & " " & sqlex.Number)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetAll() As List(Of OrderItem) Implements ICrud(Of OrderItem).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As OrderItem Implements ICrud(Of OrderItem).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As OrderItem) As Integer Implements ICrud(Of OrderItem).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of OrderItem).Delete
        Throw New NotImplementedException()
    End Function
End Class
