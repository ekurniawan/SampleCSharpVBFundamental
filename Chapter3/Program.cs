// See https://aka.ms/new-console-template for more information

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


//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    Console.WriteLine("You rolled doubles! +2 bonus to total!");
//    total += 2;
//}

//if ((roll1 == roll2) && (roll2 == roll3))
//{
//    Console.WriteLine("You rolled triples! +6 bonus to total!");
//    total += 6;
//}

//if (total >= 15)
//{
//    Console.WriteLine("You win!");
//}

//if (total < 15)
//{
//    Console.WriteLine("Sorry, you lose.");
//}


//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";

//for(int i = 0; i < fraudulentOrderIDs.Length; i++)
//{
//    Console.WriteLine(fraudulentOrderIDs[i]);
//}

//foreach(string strOrderId in fraudulentOrderIDs)
//{
//    Console.WriteLine(strOrderId);
//}


//string[] arrName = [ "John", "Doe","Erick","Budi" ];
//fraudulentOrderIDs[3] = "D000";
//Console.WriteLine(fraudulentOrderIDs[3]);
//Console.WriteLine(arrName[0]);


//ArrayList arrNama = new ArrayList();
//arrNama.Add(12);
//arrNama.Add(13);
//arrNama.Add("Erick");
//arrNama.Add(20);
//arrNama.Add(30);

//Console.WriteLine(arrNama[0]);
//Console.WriteLine(arrNama[2]);

//foreach(int number in arrNama)
//{
//    Console.WriteLine(number);
//}

//List<int> lstNumbers = new List<int> { 12, 13, 45, 55, 88 };
//List<int> lstNumbers = new List<int>();
//lstNumbers.Add(12);
//lstNumbers.Add(13); 
//lstNumbers.Add(20);
//lstNumbers.Add(30);
//lstNumbers.Add(40);

//Console.WriteLine(lstNumbers[0]);
//foreach (int number in lstNumbers)
//{
//    Console.WriteLine(number);
//}

//Stack<int> myStacks = new Stack<int>();
//myStacks.Push(12);
//myStacks.Push(13);
//myStacks.Push(20);
//myStacks.Push(30);
//myStacks.Push(40);


////Console.WriteLine(myStacks.Pop());
////Console.WriteLine(myStacks.Pop());
//foreach (int number in myStacks)
//{
//    Console.WriteLine(number);
//}

//Queue<int> myQueue = new Queue<int>();
//myQueue.Enqueue(12);
//myQueue.Enqueue(13);
//myQueue.Enqueue(20);
//myQueue.Enqueue(30);
//myQueue.Enqueue(40);

////Console.WriteLine(myQueue.Dequeue());

//foreach (int number in myQueue)
//{
//    Console.WriteLine(number);
//}

/*Dictionary<string, string> config = new Dictionary<string, string>();
config.Add("resolution", "1920x1080");
config.Add("title", "MyWebsite");
config.Add("language", "English");

Console.WriteLine(config["title"]);

foreach (KeyValuePair<string, string> item in config)
{
    Console.WriteLine($"{item.Key} = {item.Value}");
}*/

//Student student1 = new Student();
//student1.setFirstName("Erick");
//Console.WriteLine(student1.getFirstName());

//Student student2 = new Student();
//student2.FirstName = "Budi";
//Console.WriteLine(student2.FirstName);
//student2.LastName = "Santosa";
//Console.WriteLine(student2.LastName);

//for (int i = 1; i <= 10; i++)
//{
//    if (i % 3 == 0)
//        continue;
//}

//string? nama = null;
//int? number1 = null;

//string.IsNullOrEmpty(nama);

//if (number1.HasValue)
//{
//    Console.WriteLine(number1.Value);
//}
//else
//{
//    Console.WriteLine("number1 is null");
//}

//MyLib.Person person = new MyLib.Person();

//string value = "abc123";
//char[] valueArray = value.ToCharArray();
//Array.Reverse(valueArray);
//// string result = new string(valueArray);
//string result = String.Join(",", valueArray);
//Console.WriteLine(result);


//string message = "Help (find) the {opening symbols}";
//Console.WriteLine($"Searching THIS Message: {message}");
//char[] openSymbols = { '[', '{', '(' };
//int startPosition = 5;
//int openingPosition = message.IndexOfAny(openSymbols);
//Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

//openingPosition = message.IndexOfAny(openSymbols, startPosition);
//Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

//string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

//string messageText = "";

//foreach (string name in names)
//{
//    if (name == "Sophia")
//        messageText = SophiaMessage();
//    else if (name == "Andrew")
//        messageText = AndrewMessage();
//    else if (name == "AllGreetings")
//        messageText = SophiaMessage();
//    messageText = messageText + "\n\r" + AndrewMessage();

//    Console.WriteLine(messageText + "\n\r");
//}

//bool pauseCode = true;
//while (pauseCode == true) ;

//static string SophiaMessage()
//{
//    return "Hello, my name is Sophia.";
//}

//static string AndrewMessage()
//{
//    return "Hi, my name is Andrew. Good to meet you.";
//}

//double float1 = 3000.0;
//double float2 = 0.0;
//int number1 = 3000;
//int number2 = 0;

//int[] numbers = new int[3];

//try
//{
//    //numbers[10] = 12;
//    Console.WriteLine(float1 / float2);
//    Console.WriteLine(number1 / number2);
//}
//catch (IndexOutOfRangeException ioeEx)
//{
//    Console.WriteLine($"An index was out of range! {ioeEx.Message}");
//}
//catch (DivideByZeroException dbzEx)
//{
//    Console.WriteLine($"You attempted to divide by zero! {dbzEx.Message}");
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"{ex.Message}");
//}


//Time time1 = new Time();
//Time time2 = new Time(2024, 2, 2, 5, 30, 20);
//Time time3 = new Time(DateTime.Now);

//time1.Year = 2022;
//time1.Month = 2;

//Kucing.BanyakKucing();

//Window myWindow = new Window(5, 10);
//myWindow.Top = 20;
//myWindow.Left = 30;
////myWindow.DrawWindow();

//ListBox myListBox = new ListBox(20, 30, "Hello, World!");
//myListBox.Top = 30;
//myListBox.Left = 40;
//myListBox.ListBoxContent = "Hello, World!";
////myListBox.DrawWindow();

//Button myButton = new Button(40, 50);
//myButton.Top = 50;
//myButton.Left = 60;
//myButton.FontColor = "Blue";
////myButton.DrawWindow();

//Window[] windows = new Window[3];
//windows[0] = myWindow;
//windows[1] = myListBox;
//windows[2] = myButton;

//windows[0].DrawWindow();
//Console.WriteLine(windows[0].Top + "," + windows[0].Left);
//windows[1].DrawWindow();
//Console.WriteLine($"{windows[1].Top} , {windows[1].Left}");
//windows[2].DrawWindow();

//Console.WriteLine(windows[0] is Window);

//var lstBox = windows[1] as ListBox;
//Console.WriteLine(windows[1] is ListBox);
//Console.WriteLine(lstBox is ListBox);
//Console.WriteLine($"ListBox Content: {lstBox.ListBoxContent}");

//Console.WriteLine(windows[2] is Window);
//Console.WriteLine(windows[2] is ListBox);
//Console.WriteLine(windows[2] is Button);

//List<Control> controls = new List<Control>();
//controls.Add(new ListBox(10, 10, "First List Box"));
//controls.Add(new Button(20, 20));

//GridData gridData = new GridData(30, 30, 40, 40);
//controls.Add(gridData);

//foreach (Control control in controls)
//{
//    if (control is ListBox)
//    {
//        ListBox listBox = control as ListBox;
//        listBox.ListBoxContent = "Content of List Box";
//        listBox.DrawWindow();
//    }
//    else if (control is Button)
//    {
//        Button button = control as Button;
//        button.FontColor = "Red";
//        button.DrawWindow();
//    }
//}

using SampleCSharp;

List<ICompressable> documents = new List<ICompressable>();
documents.Add(new Document());
documents.Add(new Image());


foreach (ICompressable document in documents)
{
    document.Compress();
    document.Decompress();
}