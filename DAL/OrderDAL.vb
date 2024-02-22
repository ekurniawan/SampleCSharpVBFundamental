Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports BO
Imports MyInterface

Public Class OrderDAL
    Implements IOrder

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        conn = New SqlConnection(ConfigurationManager.AppSettings.Get("MyConnectionString"))
    End Sub


    Public Function GetOrders() As List(Of ViewOrder) Implements IOrder.GetOrders
        Dim Orders As New List(Of ViewOrder)
        Try
            Dim strSP = "Orders.GetOrders"
            cmd = New SqlCommand(strSP, conn)
            cmd.CommandType = CommandType.StoredProcedure
            conn.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    Dim order As New ViewOrder
                    order.StockSKU = dr("StockSKU").ToString()
                    order.StockName = dr("StockName").ToString()
                    order.StockPrice = CDec(dr("StockPrice"))
                    order.CustName = dr("CustName").ToString()
                    order.Quantity = CInt(dr("Quantity"))
                    order.Discount = CDec(dr("Discount"))
                    order.Total = CDec(dr("Total"))
                    Orders.Add(order)
                End While
            End If
            dr.Close()

            Return Orders
        Catch sqlex As SqlException
            Throw New ArgumentException(sqlex.Message & " " & sqlex.Number)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function Create(obj As Order) As Integer Implements ICrud(Of Order).Create
        Try
            Dim strSql = "INSERT INTO [Orders].[OrderItems] ([OrderDate],[OrderRequestedDate],[OrderDeliveryDate],[CustID],[OrderIsExpedited]) 
            VALUES (@OrderDate,@OrderRequestedDate,@OrderDeliveryDate,@CustID,@OrderIsExpedited)"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@OrderDate", obj.OrderDate)
            cmd.Parameters.AddWithValue("@OrderRequestedDate", obj.OrderRequestedDate)
            cmd.Parameters.AddWithValue("@OrderDeliveryDate", obj.OrderDeliveryDate)
            cmd.Parameters.AddWithValue("@CustID", obj.CustID)
            cmd.Parameters.AddWithValue("@OrderIsExpedited", obj.OrderIsExpedited)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery()
            If result <> 1 Then
                Throw New ArgumentException("Order not created")
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

    Public Function GetAll() As List(Of Order) Implements ICrud(Of Order).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As Order Implements ICrud(Of Order).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Order) As Integer Implements ICrud(Of Order).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Order).Delete
        Throw New NotImplementedException()
    End Function
End Class
