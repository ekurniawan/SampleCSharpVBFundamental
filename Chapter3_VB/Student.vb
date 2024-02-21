Option Strict On

Public Class Student
    Private _firstName As String = "Erick"

    Public Property LastName As String = "Kurniawan"

    Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Public Function getFullName() As String
        Return _firstName & " " & _lastName
    End Function

    Public Function getFullName(firstName As String, lastName As String) As String
        Return firstName & " " & lastName
    End Function

    Public Function getFullName(firstName As String, lastName As String, address As String) As String
        Return firstName & " " & lastName & " " & address
    End Function
End Class
