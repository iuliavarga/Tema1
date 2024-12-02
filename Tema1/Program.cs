// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,");

Console.WriteLine("Please input your First Name: ");
string FirstName = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Please input your Last Name: ");
string LastName = Console.ReadLine();

Console.WriteLine("\n");

Console.WriteLine("Please input your Age: ");
int Age = int.Parse(Console.ReadLine());

int CalculateAge = Age + 20;

Console.WriteLine("\n");

Console.WriteLine("Please input your Gender: ");
string Gender = Console.ReadLine();


Console.WriteLine("\n"); 

Console.WriteLine("Your details are as follows: ");
Console.WriteLine("- First name: " + FirstName);
Console.WriteLine("- Last name: " + LastName);
Console.WriteLine("- Gender: " + Gender);
Console.WriteLine("You will be " +CalculateAge + " years old in 20 years");