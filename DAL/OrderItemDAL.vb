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
        Throw New NotImplementedException()
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
