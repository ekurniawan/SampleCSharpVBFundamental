Public Class Window
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

    Public Sub New(_top As Integer, _left As Integer)
        Me._left = _left
        Me._top = _top
    End Sub

    Public Overridable Sub DrawWindow()
        Console.WriteLine("Drawing Window at " & _top & ", " & _left)
    End Sub

End Class

Public Class ListBox
    Inherits Window

    Private _listBoxContent As String
    Public Property ListBoxContent() As String
        Get
            Return _listBoxContent
        End Get
        Set(ByVal value As String)
            _listBoxContent = value
        End Set
    End Property

    Public Sub New(_top As Integer, _left As Integer, _listBoxContent As String)
        MyBase.New(_top, _left)
        Me._listBoxContent = _listBoxContent
    End Sub

    Public Overrides Sub DrawWindow()
        'MyBase.DrawWindow()
        Console.WriteLine("Draw List box content:  {0} {1} {2}", Top, Left, ListBoxContent)
    End Sub

End Class

Public Class Button
    Inherits Window

    Private _buttonName As String
    Public Property ButtonName() As String
        Get
            Return _buttonName
        End Get
        Set(ByVal value As String)
            _buttonName = value
        End Set
    End Property

    Public Sub New(_top As Integer, _left As Integer, _buttonName As String)
        MyBase.New(_top, _left)
        Me._buttonName = _buttonName
    End Sub

    Public Overrides Sub DrawWindow()
        'MyBase.DrawWindow()
        Console.WriteLine("Draw Button:  {0} {1} {2}", Top, Left, ButtonName)
    End Sub

End Class