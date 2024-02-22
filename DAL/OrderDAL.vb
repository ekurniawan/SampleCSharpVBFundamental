Imports System.Data
Imports System.Data.SqlClient
Imports BO
Imports MyInterface

Public Class OrderDAL
    Implements IOrder

    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader


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
        Throw New NotImplementedException()
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
