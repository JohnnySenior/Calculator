Console.WriteLine("Welcome to Calculator Application");

Console.Write("Enter first number: ");
decimal firstNumber = decimal.Parse(Console.ReadLine());

Console.Write("Option [+, -, *, /, %]: ");
string option = Console.ReadLine();

Console.Write("Enter second number: ");
decimal secondNumber = decimal.Parse(Console.ReadLine());

string template = $"Add: {firstNumber} {option} {secondNumber} =";

Console.WriteLine("There are calculation process:");

decimal result = option switch
{
    "+" => firstNumber + secondNumber,
    "-" => firstNumber - secondNumber,
    "*" => firstNumber * secondNumber,
    "/" => firstNumber / secondNumber,
    "%" => firstNumber % secondNumber,
       _=> 0
};

Console.WriteLine($"{template} {result}");

Console.Write("Enter your age: ");
string stringAge = Console.ReadLine();
int age = int.Parse(stringAge);

string message = (age >= 18 && age < 28)
                    ? "You are eligible for military service."
                    : "You are not eligible for military service.";

Console.WriteLine(message);