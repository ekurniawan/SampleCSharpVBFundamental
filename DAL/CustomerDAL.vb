Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports BO
Imports MyInterface


Public Class CustomerDAL
    Implements ICustomer

    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        'conn = New SqlConnection(Helpers.DbConnection.ConnectionString)
        conn = New SqlConnection(ConfigurationManager.AppSettings.Get("MyConnectionString"))
    End Sub

    Public Function GetByName() As List(Of Customer) Implements ICustomer.GetByName
        Throw New NotImplementedException()
    End Function


    Public Function Create(obj As Customer) As Integer Implements ICrud(Of Customer).Create
        Try
            Dim strSP = "usp_InsertCustomer"
            cmd = New SqlCommand(strSP, conn)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CustName", obj.CustName)
            cmd.Parameters.AddWithValue("@CustStreet", obj.CustStreet)
            cmd.Parameters.AddWithValue("@CustCity", obj.CustCity)
            cmd.Parameters.AddWithValue("@CustStateProv", obj.CustStateProv)
            cmd.Parameters.AddWithValue("@CustCountry", obj.CustCountry)
            cmd.Parameters.AddWithValue("@CustPostalCode", obj.CustPostalCode)
            cmd.Parameters.AddWithValue("@SalutationID", obj.SalutationID)

            conn.Open()
            Dim result = cmd.ExecuteNonQuery()
            If result <> 1 Then
                Throw New ArgumentException("Customer not created")
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

    Public Function GetAll() As List(Of Customer) Implements ICrud(Of Customer).GetAll
        Dim Customers As New List(Of Customer)
        Try
            Dim strSql = "SELECT * FROM Orders.Customers order by CustName"

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

    Public Function GetById(id As Integer) As Customer Implements ICrud(Of Customer).GetById
        Try
            cmd = New SqlCommand("SELECT * FROM Orders.Customers WHERE CustID = @CustID", conn)
            cmd.Parameters.AddWithValue("@CustID", id)
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

    Public Function Update(obj As Customer) As Integer Implements ICrud(Of Customer).Update
        Try
            Dim updateCust = GetById(obj.CustID)
            If updateCust Is Nothing Then
                Throw New ArgumentException("Customer not found")
            End If

            Dim strSql = "UPDATE Orders.Customers SET CustName = @CustName, CustStreet = @CustStreet, CustCity = @CustCity, " &
                "CustStateProv = @CustStateProv, CustCountry = @CustCountry, CustPostalCode = @CustPostalCode, SalutationID = @SalutationID " &
                "WHERE CustID = @CustID"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@CustID", obj.CustID)
            cmd.Parameters.AddWithValue("@CustName", obj.CustName)
            cmd.Parameters.AddWithValue("@CustStreet", obj.CustStreet)
            cmd.Parameters.AddWithValue("@CustCity", obj.CustCity)
            cmd.Parameters.AddWithValue("@CustStateProv", obj.CustStateProv)
            cmd.Parameters.AddWithValue("@CustCountry", obj.CustCountry)
            cmd.Parameters.AddWithValue("@CustPostalCode", obj.CustPostalCode)
            cmd.Parameters.AddWithValue("@SalutationID", obj.SalutationID)

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

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Customer).Delete
        Try
            Dim strSql = "DELETE FROM Orders.Customers WHERE CustID = @CustID"
            cmd = New SqlCommand(strSql, conn)
            cmd.Parameters.AddWithValue("@CustID", id)

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

    Public Function GetCustomerWithSalutation() As List(Of Customer) Implements ICustomer.GetCustomerWithSalutation
        Dim Customers As New List(Of Customer)
        Try
            Dim strSql = "SELECT Orders.Customers.CustID, Orders.Customers.CustName, Orders.Customers.CustStreet, " &
             "Orders.Customers.CustCity, Orders.Customers.CustStateProv, Orders.Customers.CustCountry, Orders.Customers.CustPostalCode, " &
             "Orders.Customers.SalutationID, " &
             "Orders.Salutations.Salutation " &
             "FROM Orders.Customers INNER JOIN " &
             "Orders.Salutations ON Orders.Customers.SalutationID = Orders.Salutations.SalutationID"

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
                    cust.Salutation = New Salutation()
                    cust.Salutation.SalutationID = CInt(dr("SalutationID"))
                    cust.Salutation.Salutation = dr("Salutation").ToString()
                    Customers.Add(cust)
                End While
            End If


            Return Customers
        Catch sqlex As SqlException
            Throw New ArgumentException(sqlex.Message & " " & sqlex.Number)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function
End Class
