// See https://aka.ms/new-console-template for more information
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

Random random = new Random();
int randomNumber = random.Next(1, 7);
Console.WriteLine(randomNumber);

Student student = new Student();
Console.WriteLine(student.getFullName());
Console.WriteLine(student.getFullName("Tanjiro", "Kamado"));
Console.WriteLine(student.getFullName("Tanjiro", "Kamado", "Tokyo"));
