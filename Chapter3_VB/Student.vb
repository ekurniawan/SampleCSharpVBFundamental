﻿


Public Class Student
    Private firstName As String = "Erick"
    Private lastName As String = "Santos"

    Public Function getFullName() As String
        Return firstName & " " & lastName
    End Function

    Public Function getFullName(firstName As String, lastName As String) As String
        Return firstName & " " & lastName
    End Function

    Public Function getFullName(firstName As String, lastName As String, address As String) As String
        Return firstName & " " & lastName & " " & address
    End Function
End Class