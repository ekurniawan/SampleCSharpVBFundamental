Imports System.Data.SqlClient
Imports BO
Imports MyInterface

Public Class CustomerDAL
    Implements ICustomer

    Private strConn As String
    Private conn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        strConn = "Server=ACTUAL;Database=BobsShoes;Trusted_Connection=True;"
        conn = New SqlConnection(strConn)
    End Sub

    Public Function GetByName() As List(Of Customer) Implements ICustomer.GetByName
        Throw New NotImplementedException()
    End Function

    Public Function GetOrder() As List(Of ViewOrder) Implements ICustomer.GetOrder
        Throw New NotImplementedException()
    End Function

    Public Function Create(obj As Customer) As Integer Implements ICrud(Of Customer).Create
        Throw New NotImplementedException()
    End Function

    Public Function GetAll() As List(Of Customer) Implements ICrud(Of Customer).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As Customer Implements ICrud(Of Customer).GetById
        Throw New NotImplementedException()
    End Function

    Public Function Update(obj As Customer) As Integer Implements ICrud(Of Customer).Update
        Throw New NotImplementedException()
    End Function

    Public Function Delete(id As Integer) As Integer Implements ICrud(Of Customer).Delete
        Throw New NotImplementedException()
    End Function
End Class
