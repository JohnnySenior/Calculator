Console.WriteLine("Welcome to Calculator Application");

Console.Write("Enter first number: ");
var firstNumber = decimal.Parse(Console.ReadLine());

Console.Write("Enter operation that you need ('+' '-' '/' '*' '%'): ");
var operation = char.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
var secondNumber = decimal.Parse(Console.ReadLine());

var result = operation switch
{
    '+' => firstNumber + secondNumber,
    '-' => firstNumber - secondNumber,
    '/' => firstNumber / secondNumber,
    '*' => firstNumber * secondNumber,
    '%' => firstNumber % secondNumber,
    _ => throw new Exception("You entered wrong operation, try again")  
};

Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {result}");