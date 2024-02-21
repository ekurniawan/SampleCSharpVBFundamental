Option Strict On
Option Infer On
Imports System.Text



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


        Dim r = 1
        Select Case r
            Case 1
                Console.WriteLine("Case 1")
            Case 2
                Console.WriteLine("Case 2")
            Case Else
                Console.WriteLine("Case Else")
        End Select


    End Sub

    Sub SampleArray()
        Dim arrNama(3) As String
        arrNama(0) = "Erick"
        arrNama(1) = "Santos"
        arrNama(2) = "Nezuko"

        For i = 0 To 2
            Console.WriteLine(arrNama(i))
        Next

        For Each strNama In arrNama
            Console.WriteLine(strNama)
        Next

        Dim names = {"Erick", "Santos", "Nezuko", "Kamado"}

    End Sub

    Sub SampleArrayList()
        Dim arrNumber As New ArrayList
        arrNumber.Add(10)
        arrNumber.Add(20)
        arrNumber.Add("Erick")
        arrNumber.Add(30)

        For Each number As Integer In arrNumber
            Console.WriteLine(number)
        Next
    End Sub

    Sub SampleList()

        Dim listNumber As New List(Of Integer) From {10, 20, 30}

        listNumber.Add(10)
        listNumber.Add(20)
        listNumber.Add(30)

        For Each number As Integer In listNumber
            Console.WriteLine(number)
        Next

        Dim myStack As New Stack(Of Integer)
        myStack.Push(10)
        myStack.Push(20)
        myStack.Push(30)

        Console.WriteLine(myStack.Pop())

        For Each number As Integer In myStack
            Console.WriteLine(number)
        Next

        Dim myQueue As New Queue(Of Integer)
        myQueue.Enqueue(10)
        myQueue.Enqueue(20)
        myQueue.Enqueue(30)

        Console.WriteLine(myQueue.Dequeue())

        For Each number As Integer In myQueue
            Console.WriteLine(number)
        Next

    End Sub

    Sub SampleDictionary()
        Dim dictNumber As New Dictionary(Of String, Integer)
        dictNumber.Add("One", 1)
        dictNumber.Add("Two", 2)
        dictNumber.Add("Three", 3)

        For Each number As KeyValuePair(Of String, Integer) In dictNumber
            Console.WriteLine(number.Key & " " & number.Value)
        Next
    End Sub

    Sub SampleAssignment()
        Dim examAssignments = 5

        Dim sophiaScores() As Integer = {90, 86, 87, 98, 100, 94, 90}
        Dim andrewScores() As Integer = {92, 89, 81, 96, 90, 89}
        Dim emmaScores() As Integer = {90, 85, 87, 98, 68, 89, 89, 89}
        Dim loganScores() As Integer = {90, 95, 87, 88, 96, 96}

        Dim studentNames() As String = {"Sophia", "Andrew", "Emma", "Logan"}

        Dim studentScores(10) As Integer

        Dim currentStudentLetterGrade = ""

        Console.WriteLine("Student".PadRight(15) & "Grade".PadRight(15))

        For Each name As String In studentNames
            Dim currentStudent = name
            If currentStudent = "Sophia" Then
                studentScores = sophiaScores
            ElseIf currentStudent = "Andrew" Then
                studentScores = andrewScores
            ElseIf currentStudent = "Emma" Then
                studentScores = emmaScores
            ElseIf currentStudent = "Logan" Then
                studentScores = loganScores
            End If

            Dim sumAssignmentScores = 0
            Dim currentStudentGrade = CDec(0)
            Dim gradedAssignments = 0

            For Each score As Integer In studentScores

                gradedAssignments += 1
                If gradedAssignments <= examAssignments Then
                    sumAssignmentScores += score
                Else
                    currentStudentGrade += CDec(score) / 10
                End If
            Next

            currentStudentGrade = CDec(sumAssignmentScores) / examAssignments
            If currentStudentGrade >= 97 Then
                currentStudentLetterGrade = "A+"
            ElseIf currentStudentGrade >= 93 Then
                currentStudentLetterGrade = "A"
            ElseIf currentStudentGrade >= 90 Then
                currentStudentLetterGrade = "A-"
            ElseIf currentStudentGrade >= 87 Then
                currentStudentLetterGrade = "B+"
            ElseIf currentStudentGrade >= 83 Then
                currentStudentLetterGrade = "B"
            ElseIf currentStudentGrade >= 80 Then
                currentStudentLetterGrade = "B-"
            ElseIf currentStudentGrade >= 77 Then
                currentStudentLetterGrade = "C+"
            ElseIf currentStudentGrade >= 73 Then
                currentStudentLetterGrade = "C"
            ElseIf currentStudentGrade >= 70 Then
                currentStudentLetterGrade = "C-"
            ElseIf currentStudentGrade >= 67 Then
                currentStudentLetterGrade = "D+"
            ElseIf currentStudentGrade >= 63 Then
                currentStudentLetterGrade = "D"
            ElseIf currentStudentGrade >= 60 Then
                currentStudentLetterGrade = "D-"
            Else
                currentStudentLetterGrade = "F"
            End If

            Console.WriteLine(currentStudent.PadRight(15) & currentStudentGrade.ToString.PadRight(15) & currentStudentLetterGrade.PadRight(8))
        Next
        Console.WriteLine("Press the Enter key to continue")
        Console.ReadLine()
    End Sub

    Sub Task1()
        Dim arrLocations() As String = {"Praya Barat", "Praya Barat Daya", "Pujut", "Praya Timur", "Janapria", "Kopang", "Praya", "Praya Tengah", "Jonggat", "Pringgarata", "Batukliang", "Batukliang Utara"}
        Dim arrLaki() As Integer = {41919, 29128, 59620, 36653, 43262, 47088, 63509, 37305, 53734, 38715, 45096, 30784}
        Dim arrPerempuan() As Integer = {42309, 29971, 60521, 37414, 43475, 47715, 64311, 37438, 54456, 38842, 45062, 30715}

        Console.WriteLine("Kecamatan".PadRight(20) & " " & "Laki-laki".PadLeft(10) & " " & "Perempuan".PadLeft(10) &
                          "Total".PadLeft(10) & " " & "(%) Laki-laki".PadLeft(15) & " " & "(%) Perempuan".PadLeft(15) & " " &
                           "Selisih".PadLeft(10) & " " & "Mayoritas".PadLeft(10))
        For i As Integer = 0 To arrLocations.Length - 1
            Dim total = arrLaki(i) + arrPerempuan(i)
            Dim percentLaki = CDec(arrLaki(i)) / total * 100
            Dim percentPerempuan = CDec(arrPerempuan(i)) / total * 100
            Dim selisih = Math.Abs(arrLaki(i) - arrPerempuan(i))
            Dim mayoritas = IIf(arrLaki(i) > arrPerempuan(i), "Laki-laki", "Perempuan")

            Console.WriteLine(arrLocations(i).PadRight(20) & " " & arrLaki(i).ToString.PadLeft(10) & " " & arrPerempuan(i).ToString.PadLeft(10) &
                              total.ToString.PadLeft(10) & " " & percentLaki.ToString("N2").PadLeft(15) & " " &
                              percentPerempuan.ToString("N2").PadLeft(15) & " " & selisih.ToString.PadLeft(10) &
                              " " & mayoritas.ToString.PadLeft(10))
        Next


        Dim sortLaki = arrLaki.OrderBy(Of Integer)(Function(x) x)
        For Each laki As Integer In sortLaki
            Console.WriteLine(laki.ToString)
        Next

        Dim a = True
        Console.WriteLine(Not a)

    End Sub

    Sub SampleProperty()
        Dim student1 As New Student
        student1.FirstName = "Erick"
        Console.WriteLine(student1.FirstName)

        student1.LastName = "Kurniawan"
        Console.WriteLine(student1.LastName)

    End Sub

    Sub TestExercise1()
        Dim a = 5
        If a > 0 Then
            Dim b = 6

        End If

        'Dim c = a + b
    End Sub

    Sub SampleCase()
        Dim employeeLevel = 200
        Dim employeeName = "John Smith"

        Dim title = ""

        Select Case employeeLevel
            Case 100
                title = "Junior Associate"
            Case 200
                title = "Senior Associate"
            Case 300
                title = "Manager"
            Case 400
                title = "Senior Manager"
            Case Else
                title = "Associate"
        End Select

        Select Case employeeLevel
            Case 100 Or 200
                title = "Associate"
        End Select

    End Sub

    Sub ExerciseCase()
        Dim sku = "01-MN-L"

        Dim product = sku.Split(New Char() {"-"c})

        Dim tipe = ""
        Dim color = ""
        Dim size = ""

        Select Case product(0)
            Case "01"
                tipe = "Sweat shirt"
            Case "02"
                tipe = "T-Shirt"
            Case "03"
                tipe = "Sweat pants"
            Case Else
                tipe = "Other"
        End Select

        Select Case product(1)
            Case "BL"
                color = "Black"
            Case "MN"
                color = "Maroon"
            Case Else
                color = "White"
        End Select

        Select Case product(2)
            Case "S"
                size = "Small"
            Case "M"
                size = "Medium"
            Case "L"
                size = "Large"
            Case Else
                size = "One Size Fits All"
        End Select
        Console.WriteLine("Product:" & tipe & " " & color & " " & size)

        For i As Integer = 1 To 10
            If i Mod 3 = 0 Then
                Continue For
            End If
        Next

        Dim total As Nullable(Of Integer) = Nothing

        If IsNothing(total) Then
            total = 0
        End If



    End Sub

    Sub BalikKata(param As String)
        Dim pangram = param
        Dim words = pangram.Split(" "c)
        Dim sb As New StringBuilder
        Dim wordarray(10) As String
        For Each word As String In words
            Dim charArray = word.ToCharArray()
            Array.Reverse(charArray)
            sb.Append(" " & charArray)
        Next
        Console.WriteLine(LTrim(sb.ToString()))
    End Sub

    Sub Multiplay(a As Integer, b As Integer, ByRef c As Integer)
        c = a * b
        Console.WriteLine("inside Multiply method: " & a & "x" & b & " = " & c)
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

        'SampleChallenge()
        'SampleArray()
        'SampleArrayList()
        'SampleList()
        'SampleAssignment()
        'BalikKata("The quick brown fox jumps over the lazy dog")
        Dim a = 3
        Dim b = 4
        Dim c = 0

        Multiplay(a, b, c)

        Try

        Catch ex As Exception

        Finally

        End Try

    End Sub



End Module
