Imports System.Data.SqlClient

Public Class CustomerDAL
    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private Customers As New List(Of Customer)

    Public Sub New()
        strConn = "Server=ACTUAL;Database=BobsShoes;Trusted_Connection=True;"
        conn = New SqlConnection(strConn)
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

    Public Function GetCustomerByID(custID As Integer) As Customer
        Try
            cmd = New SqlCommand("SELECT * FROM Orders.Customers WHERE CustID = @CustID", conn)
            cmd.Parameters.AddWithValue("@CustID", custID)
            conn.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                Dim cust As New Customer
                cust.CustID = CInt(dr("CustID"))
                cust.CustName = dr("CustName").ToString()
                cust.CustStreet = dr("CustStreet").ToString()
                cust.CustCity = dr("CustCity").ToString()
                cust.CustStateProv = dr("CustStateProv").ToString()
                cust.CustCountry = dr("CustCountry").ToString()
                cust.CustPostalCode = dr("CustPostalCode").ToString()
                cust.SalutationID = CInt(dr("SalutationID"))
                Return cust
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function InsertCustomers(cust As Customer) As Integer
        Try
            Dim strSql = "INSERT INTO Orders.Customers (CustName, CustStreet, CustCity, CustStateProv, CustCountry, CustPostalCode, SalutationID) " &
                " VALUES (@CustName, @CustStreet, @CustCity, @CustStateProv, @CustCountry, @CustPostalCode, @SalutationID)"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@CustName", cust.CustName)
            cmd.Parameters.AddWithValue("@CustStreet", cust.CustStreet)
            cmd.Parameters.AddWithValue("@CustCity", cust.CustCity)
            cmd.Parameters.AddWithValue("@CustStateProv", cust.CustStateProv)
            cmd.Parameters.AddWithValue("@CustCountry", cust.CustCountry)
            cmd.Parameters.AddWithValue("@CustPostalCode", cust.CustPostalCode)
            cmd.Parameters.AddWithValue("@SalutationID", cust.SalutationID)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery()
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

    Public Function UpdateCustomers(cust As Customer) As Integer
        Try
            Dim updateCust = GetCustomerByID(cust.CustID)
            If updateCust Is Nothing Then
                Throw New ArgumentException("Customer not found")
            End If

            Dim strSql = "UPDATE Orders.Customers SET CustName = @CustName, CustStreet = @CustStreet, CustCity = @CustCity, " &
                "CustStateProv = @CustStateProv, CustCountry = @CustCountry, CustPostalCode = @CustPostalCode, SalutationID = @SalutationID " &
                "WHERE CustID = @CustID"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@CustID", cust.CustID)
            cmd.Parameters.AddWithValue("@CustName", cust.CustName)
            cmd.Parameters.AddWithValue("@CustStreet", cust.CustStreet)
            cmd.Parameters.AddWithValue("@CustCity", cust.CustCity)
            cmd.Parameters.AddWithValue("@CustStateProv", cust.CustStateProv)
            cmd.Parameters.AddWithValue("@CustCountry", cust.CustCountry)
            cmd.Parameters.AddWithValue("@CustPostalCode", cust.CustPostalCode)
            cmd.Parameters.AddWithValue("@SalutationID", cust.SalutationID)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery()
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

    Public Function DeleteCustomers(custID As Integer) As Integer
        Try
            Dim strSql = "DELETE FROM Orders.Customers WHERE CustID = @CustID"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@CustID", custID)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery()
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
