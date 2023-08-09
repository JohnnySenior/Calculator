int firstOption = 0;
do
{
    ShowMenu();

    ConvertInputOption();

    if (firstOption == 1)
    {
        Calculate();
    }
    else if (firstOption == 2)
    {
        CalculateAgeEligibleForMilitaryService();
    }
    else if (firstOption == 3)
    {
        MultiplicationTable();
    }
    else if (firstOption == 4)
    {
        ExitFromProgram();
    }
    else
    {
        DefaultCase();
    }

} while (firstOption != 4);

void ShowMenu()
{
    Console.WriteLine("Universal Calculator Application");
    Console.WriteLine("1. Basic Calculator.");
    Console.WriteLine("2. Age Calculator");
    Console.WriteLine("3. Multiplication table");
    Console.WriteLine("4. Exit");
    Console.Write("Choose option:");
}

void ConvertInputOption()
{
    try
    {
        firstOption = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    catch (FormatException formatException)
    {
        Console.WriteLine("The input is not in a correct format");
    }
    catch (OverflowException overflowException)
    {
        Console.WriteLine("Value is too large or too small, take a look data type.");
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }
}

void Calculate()
{
    string firstUserValue = GetInputByMessage("Enter first number: ");
    string option = GetInputByMessage("Option [+, -, *, /, %]: ");
    string secondUserValue = GetInputByMessage("Enter second number: ");
    Console.Clear();

    decimal firstNumber = ConvertValueToDecimal(firstUserValue);
    decimal secondNumber = ConvertValueToDecimal(secondUserValue);

    string template = $"Add: {firstNumber} {option} {secondNumber} =";

    Console.WriteLine("There are calculation process:");

    decimal result = BasicCalculate(option, firstNumber, secondNumber);

    Console.WriteLine($"{template} {result}");
}

void CalculateAgeEligibleForMilitaryService()
{
    string stringAge = GetInputByMessage("Enter your age: ");
    int age = int.Parse(stringAge);
    Console.Clear();

    string message = (age >= 18 && age < 28)
                        ? "You are eligible for military service."
                        : "You are not eligible for military service.";

    Console.WriteLine(message);
}

void MultiplicationTable()
{
    long firstNumber = ConvertValueToLong("Enter first number, starting of the table:");
    long lastNumber = ConvertValueToLong("Enter last number, ending of the table:");
    long inlineFirstNumber = ConvertValueToLong("Enter inline first number:");
    long inlineLastNumber = ConvertValueToLong("Enter inline last number:");
    Console.Clear();

    for (long iteration = firstNumber; iteration <= lastNumber; iteration++)
    {
        Console.WriteLine("******************************");

        for (long inlineIteration = inlineFirstNumber; inlineIteration <= inlineLastNumber; inlineIteration++)
        {
            Console.WriteLine($"{iteration} * {inlineIteration} = {iteration * inlineIteration}");
        }
    }
}

void ExitFromProgram()
{
    Console.WriteLine("Thank you for using our app.");
}

void DefaultCase()
{
    Console.WriteLine("We have only three function, check and try again!!!");
}

string GetInputByMessage(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

decimal ConvertValueToDecimal(string value)
{
    return decimal.Parse(value);
}

long ConvertValueToLong(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return long.Parse(value);
}

decimal BasicCalculate(string option, decimal firstNumber, decimal secondNumber)
{
    return option switch
    {
        "+"=> Sum(firstNumber, secondNumber),
        "-" => Subtract(firstNumber, secondNumber),
        "*" => Multiply(firstNumber, secondNumber),
        "/" => Divide(firstNumber, secondNumber),
        "%" => Modulo(firstNumber, secondNumber),
        _ => 0
    };
}

decimal Sum(decimal firstNumber, decimal secondNumber)
{
    return firstNumber + secondNumber;
}

decimal Subtract(decimal firstNumber, decimal secondNumber)
{
    return firstNumber - secondNumber;
}

decimal Multiply(decimal firstNumber, decimal secondNumber)
{
    return firstNumber * secondNumber;
}

decimal Divide(decimal firstNumber, decimal secondNumber)
{
    return firstNumber / secondNumber;
}

decimal Modulo(decimal firstNumber, decimal secondNumber)
{
    return firstNumber % secondNumber;
}

