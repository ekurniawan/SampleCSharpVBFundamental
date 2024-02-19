Option Strict On
Option Infer On

Class Employee
    Public Name As String
    Public Age As Integer
    Public Salary As Double
End Class

Module Module1

    Sub Main()
        'Dim emp1 As New Employee
        'emp1.Name = "John"
        'emp1.Age = 30

        'Dim emp2 As Employee = emp1
        'emp1.Age = 40

        'Dim number1 As Integer = 10
        'Dim number2 As Integer = 20

        'number2 = number1
        'number1 = 30

        'Dim sql As String = "SELECT * FROM Employees " +
        '    "WHERE EmployeeID = 10"

        'Dim nama As String = "Erick"

        'Dim number3 As Double = 10.5
        'Dim number4 As Integer = Convert.ToInt32(number3)

        'Dim number5 = 10

        'Dim totalnumber = 12.5 * number5
        'Console.WriteLine(totalnumber)

        Dim random As Random = New Random()
        Dim randomResult = random.Next(1, 100)
    End Sub

End Module
