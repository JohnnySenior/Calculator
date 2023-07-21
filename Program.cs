Console.WriteLine("Welcome to Calculator Application");

Console.Write("Enter first number: ");
decimal firstNumber = decimal.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
decimal secondNumber = decimal.Parse(Console.ReadLine());

Console.WriteLine("There are calculation process:");

Console.WriteLine($"Add: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"Substract: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"Multiple: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"Divide: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"Module: {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");

Console.Write("Enter your age: ");
string stringAge = Console.ReadLine();
int age = int.Parse(stringAge);

string message = (age >= 18 && age < 28)
                    ? "You are eligible for military service."
                    : "You are not eligible for military service.";

Console.WriteLine(message);