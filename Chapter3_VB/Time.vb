Public NotInheritable Class Kucing
    Private Shared instance As Integer

    Public Sub New()
        instance += 1
    End Sub

    Public Shared Sub BanyakKucing()
        Console.WriteLine("Banyak kucing: " & instance)
    End Sub
End Class


Public Class Time
    Private _year As Integer
    Private _month As Integer
    Private _date As Integer
    Private _hour As Integer
    Private _minute As Integer
    Private _second As Integer

    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public Property Month As Integer
        Get
            Return _month
        End Get
        Set(value As Integer)
            _month = value
        End Set
    End Property

    Public Property MyDate As Integer
        Get
            Return _date
        End Get
        Set(value As Integer)
            _date = value
        End Set
    End Property

    Public Property Hour As Integer
        Get
            Return _hour
        End Get
        Set(value As Integer)
            _hour = value
        End Set
    End Property

    Public Property Minute As Integer
        Get
            Return _minute
        End Get
        Set(value As Integer)
            _minute = value
        End Set
    End Property

    Public Property Second As Integer
        Get
            Return _second
        End Get
        Set(value As Integer)
            _second = value
        End Set
    End Property


    Public Sub New()
        _year = 2024
        _month = 2
        _date = 29
        _hour = 12
        _minute = 0
        _second = 0
    End Sub

    Public Sub New(year As Integer, month As Integer, mydate As Integer, hour As Integer, minute As Integer, second As Integer)
        _year = year
        _month = month
        _date = mydate
        _hour = hour
        _minute = minute
        _second = second
    End Sub

    Public Sub New(dt As DateTime)
        _year = dt.Year
        _month = dt.Month
        _date = dt.Day
        _hour = dt.Hour
        _minute = dt.Minute
        _second = dt.Second
    End Sub
End Class
