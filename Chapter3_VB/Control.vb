

Public MustInherit Class Control
    Private _top As Integer
    Public Property Top() As Integer
        Get
            Return _top
        End Get
        Set(ByVal value As Integer)
            _top = value
        End Set
    End Property

    Private _left As String
    Public Property Left() As String
        Get
            Return _left
        End Get
        Set(ByVal value As String)
            _left = value
        End Set
    End Property

    Public Sub New(_top As Integer, _left As String)
        Me._top = _top
        Me._left = _left
    End Sub

    Public MustOverride Sub DrawWindow()
End Class

Public Class ListBox
    Inherits Control

    Private _listBoxContent As String
    Public Property ListBoxContent() As String
        Get
            Return _listBoxContent
        End Get
        Set(ByVal value As String)
            _listBoxContent = value
        End Set
    End Property

    Public Sub New(_top As Integer, _left As String, _listBoxContent As String)
        MyBase.New(_top, _left)
        Me._listBoxContent = _listBoxContent
    End Sub

    Public Overrides Sub DrawWindow()
        Console.WriteLine("Drawing ListBox at " & Me.Top & " and " & Me.Left & " with content " & Me.ListBoxContent)
    End Sub
End Class

Public Class Button
    Inherits Control

    Private _buttonContent As String
    Public Property ButtonContent() As String
        Get
            Return _buttonContent
        End Get
        Set(ByVal value As String)
            _buttonContent = value
        End Set
    End Property

    Public Sub New(_top As Integer, _left As String, _buttonContent As String)
        MyBase.New(_top, _left)
        Me._buttonContent = _buttonContent
    End Sub

    Public Overrides Sub DrawWindow()
        Console.WriteLine("Drawing Button at " & Me.Top & " and " & Me.Left & " with content " & Me.ButtonContent)
    End Sub
End Class
