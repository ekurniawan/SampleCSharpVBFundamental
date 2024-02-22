Imports System.Data.SqlClient

Public Class CustomerDAL
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Customers As New List(Of Customer)

    Public Sub New()
        strConn = "Server=ACTUAL;Database=BobsShoes;Trusted_Connection=True;"
    End Sub

    Public Function GetCustomers() As List(Of Customer)
        Try
            Dim strSql = "SELECT * FROM Orders.Customers order by CustName"

            conn = New SqlConnection(strConn)
            cmd = New SqlCommand(strSql, conn)
            conn.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    Dim cust As New Customer
                    cust.CustID = CInt(dr("CustID"))
                    cust.CustName = dr("CustName").ToString()
                    cust.CustStreet = dr("CustStreet").ToString()
                    cust.CustCity = dr("CustCity").ToString()
                    cust.CustStateProv = dr("CustStateProv").ToString()
                    cust.CustCountry = dr("CustCountry").ToString()
                    cust.CustPostalCode = dr("CustPostalCode").ToString()
                    cust.SalutationID = CInt(dr("SalutationID"))
                    Customers.Add(cust)
                End While
            End If
            dr.Close()

            Return Customers
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetCustomerWithDS() As DataSet
        Try
            Dim strSql = "SELECT * FROM Orders.Customers order by CustName"

            conn = New SqlConnection(strConn)
            cmd = New SqlCommand(strSql, conn)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            conn.Open()

            da.Fill(ds, "Customers")

            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function
End Class
