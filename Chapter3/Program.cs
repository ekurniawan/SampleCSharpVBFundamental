﻿// See https://aka.ms/new-console-template for more information
using Chapter3;
using Chapter4;
using SampleCSharp;


//Employee employee1 = new Employee();
//employee1.Name = "John Doe";
//employee1.Age = 30;


//var employee2 = new Employee();
//employee2.Name = "Jane Doe";
//employee2.Age = 30;

//var employee3 = employee2;


//Console.WriteLine(employee1.Name == employee2.Name);
//Console.WriteLine(employee1.Age == employee2.Age);
//Console.WriteLine(employee1 == employee2);
//Console.WriteLine(employee2 == employee3);

//employee.setName("John Doe");

//Random random = new Random();
//int randomNumber = random.Next(1, 7);
//Console.WriteLine(randomNumber);

//Student student = new Student();
//Console.WriteLine(student.getFullName());
//Console.WriteLine(student.getFullName("Tanjiro", "Kamado"));
//Console.WriteLine(student.getFullName("Tanjiro", "Kamado", "Tokyo"));


Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
