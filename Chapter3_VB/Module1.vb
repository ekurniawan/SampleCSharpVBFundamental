'Option Strict On
'Option Infer On

'Class Employee
'    Public Name As String
'    Public Age As Integer
'    Public Salary As Double
'End Class

Module Module1

    Sub SampleChallenge()
        Dim random = New Random()
        Dim daysUntilExpiration = random.Next(12)
        Dim discountPercentage = 0

        If daysUntilExpiration = 0 Then
            Console.WriteLine("Your subscription has expired.")
        ElseIf daysUntilExpiration = 1 Then
            Console.WriteLine("Your subscription expires within a day!")
            discountPercentage = 20
        ElseIf daysUntilExpiration <= 5 Then
            Console.WriteLine("Your subscription will expire within 5 days.")
            discountPercentage = 10
        ElseIf daysUntilExpiration <= 10 Then
            Console.WriteLine("Your subscription will expire within 10 days.")
        End If

        If daysUntilExpiration > 0 Then
            Console.WriteLine($"Renew now and save {discountPercentage}%!")
        End If

    End Sub

    Sub Main()
        '        Dim emp1 As New Employee
        '        emp1.Name = "John"
        '        emp1.Age = 30

        '        Dim emp2 As Employee = emp1
        '        emp1.Age = 40

        '        Dim number1 As Integer = 10
        '        Dim number2 As Integer = 20

        '        number2 = number1
        '        number1 = 30

        '        Dim sql As String = "SELECT * FROM Employees " +
        '            "WHERE EmployeeID = 10"

        '        Dim nama As String = "Erick"

        '        Dim number3 As Double = 10.5
        '        Dim number4 As Integer = Convert.ToInt32(number3)

        '        Dim number5 = 10

        '        Dim totalnumber = 12.5 * number5
        '        Console.WriteLine(totalnumber)

        '        Dim random As Random = New Random()
        '        Dim randomResult = random.Next(1, 100)

        '        Dim student1 As New Student
        '        Console.WriteLine(student1.getFullName())
        '        Console.WriteLine(student1.getFullName("Nezuko", "Kamado"))
        '        Console.WriteLine(student1.getFullName("Nezuko", "Kamado", "123 Main St"))


        '        Dim random As New Random
        '        Dim roll1 = random.Next(1, 7)
        '        Dim roll2 = random.Next(1, 7)
        '        Dim roll3 = random.Next(1, 7)

        '        Dim total = roll1 + roll2 + roll3
        '        Console.WriteLine("Dice roll: " & roll1 & " + " & roll2 & " + " & roll3 & " = " & total)

        '        If roll1 = roll2 OrElse roll1 = roll3 OrElse roll2 = roll3 Then
        '            Console.WriteLine("You rolled doubles! +2 bonus to total!")
        '            total += 2
        '        End If

        '        If roll1 = roll2 And roll2 = roll3 Then
        '            Console.WriteLine("You rolled triples! +6 bonus to total!")
        '            total += 6
        '        End If

        '        If total >= 15 Then
        '            Console.WriteLine("You win a bonus roll!")
        '        End If

        '        If total < 15 Then
        '            Console.WriteLine("Sorry, you did not win a bonus roll.")
        '        End If

        SampleChallenge()
    End Sub

End Module
