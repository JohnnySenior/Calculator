
Console.WriteLine("Welcome to Calculator Application");

Console.Write("Enter first number: ");
decimal firstNumber = decimal.Parse(Console.ReadLine());

Console.Write("Enter operation that you need ('+' '-' '/' '*' '%'): ");
char operation = char.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
decimal secondNumber = decimal.Parse(Console.ReadLine());

decimal result = operation switch
{
    '+' => firstNumber + secondNumber,
    '-' => firstNumber - secondNumber,
    '/' => firstNumber / secondNumber,
    '*' => firstNumber * secondNumber,
    '%' => firstNumber % secondNumber,
    _ => throw new Exception("You entered wrong operation, try again")  
};

Console.WriteLine($"Result: {firstNumber} {operation} {secondNumber} = {result}");