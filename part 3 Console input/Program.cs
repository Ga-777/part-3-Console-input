// See https://aka.ms/new-console-template for more information

string name, age, currentYear, birthYear;






Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Welcome to the Console Input/math app!");
Console.WriteLine("//////////////////////////////////////");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Hello {name}, please enter your age: ");
age = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Thank you {name}, please enter the current year: ");
currentYear = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine($"Here is your info:");
Console.WriteLine("");
int ageInt;
Convert.ToInt32(age);
Int32.TryParse(age, out ageInt);
int currentYearInt = DateTime.Now.Year;
int birthYearInt = currentYearInt - ageInt;
Console.WriteLine($"Name: {name}");
Console.WriteLine();
Console.WriteLine($"Age: {age} ");
Console.WriteLine();
Console.WriteLine($"Current Year: {currentYear}");
Console.WriteLine();
Console.WriteLine($"Birth Year: {birthYearInt}");
Console.WriteLine();
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
int number1, number2,number3, sum;
Console.WriteLine("Please enter the first number: ");
int.TryParse(Console.ReadLine(), out number1);
Console.WriteLine("");
Console.WriteLine("Please enter the second number: ");
int.TryParse(Console.ReadLine(), out number2);
Console.WriteLine("");
Console.WriteLine("Please enter the third number: ");
int.TryParse(Console.ReadLine(), out number3);
Console.WriteLine("");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("would you like to add, subtract, multiply, or divide the numbers?");
Console.WriteLine("+)");
Console.WriteLine("");
Console.WriteLine("-)");
Console.WriteLine("");
Console.WriteLine("/)");
Console.WriteLine("");
Console.WriteLine("*)");
Console.WriteLine("");
string choice = Console.ReadLine();
if (choice == "+")
{
    sum = number1 + number2 + number3;
    Console.WriteLine($"The sum of {number1}, {number2}, and {number3} is: {sum}");
}
else if (choice == "-")
{
    sum = number1 - number2 - number3;
    Console.WriteLine($"The difference of {number1}, {number2}, and {number3} is: {sum}");
}
else if (choice == "*")
{
    sum = number1 * number2 * number3;
    Console.WriteLine($"The product of {number1}, {number2}, and {number3} is: {sum}");
}
else if (choice == "/")
{
    if (number2 == 0 || number3 == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
    }
    else
    {
        double result = (double)number1 / number2 / number3;
        Console.WriteLine($"The quotient of {number1}, {number2}, and {number3} is: {result}");
    }
}
else
{
    Console.WriteLine("Invalid choice. Please select +, -, *, or /.");
}
decimal kiloMeter, kiloMeter2, kiloMeter3, sumKiloMeter;
Console.WriteLine("");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Welcome to the kilometer math app!");
Console.WriteLine("");
Console.WriteLine("Please enter the first kilometer value: ");
decimal.TryParse(Console.ReadLine(), out kiloMeter);
Console.WriteLine("");
Console.WriteLine("Please enter the second kilometer value: ");
decimal.TryParse(Console.ReadLine(), out kiloMeter2);
Console.WriteLine("");
Console.WriteLine("Please enter the third kilometer value: ");
decimal.TryParse(Console.ReadLine(), out kiloMeter3);
Console.WriteLine("");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
sumKiloMeter = kiloMeter + kiloMeter2 + kiloMeter3;
sumKiloMeter = sumKiloMeter / 3;
sumKiloMeter = Math.Round(sumKiloMeter, 2);
Console.WriteLine("The average of the three kilometer values is: " + sumKiloMeter + " km");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
Console.WriteLine("Right triangle area calculator");
decimal legA, legB, triangleSum;
Console.WriteLine("Please enter the length of leg A: ");
decimal.TryParse(Console.ReadLine(), out legA);
Console.WriteLine("");
Console.WriteLine("Please enter the length of leg B: ");
decimal.TryParse(Console.ReadLine(), out legB);
Console.WriteLine("");
Console.WriteLine("press enter to contiune");
Console.ReadLine();
Console.Clear();
Thread.Sleep(1000);
triangleSum = (legA + legB) / 2;

