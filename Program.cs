int firstOption = 0;
do
{
    Console.WriteLine("Universal Calculator Application");
    Console.WriteLine("1. Basic Calculator.");
    Console.WriteLine("2. Age Calculator");
    Console.WriteLine("3. Multiplication table");
    Console.WriteLine("4. Exit");
    Console.Write("Choose option:");

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


    if (firstOption == 1)
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());

        Console.Write("Option [+, -, *, /, %]: ");
        string option = Console.ReadLine();

        Console.Write("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Clear();

        string template = $"Add: {firstNumber} {option} {secondNumber} =";

        Console.WriteLine("There are calculation process:");

        decimal result = option switch
        {
            "+" => firstNumber + secondNumber,
            "-" => firstNumber - secondNumber,
            "*" => firstNumber * secondNumber,
            "/" => firstNumber / secondNumber,
            "%" => firstNumber % secondNumber,
            _ => 0
        };

        Console.WriteLine($"{template} {result}");
    }
    else if (firstOption == 2)
    {
        Console.Write("Enter your age: ");
        string stringAge = Console.ReadLine();
        int age = int.Parse(stringAge);
        Console.Clear();

        string message = (age >= 18 && age < 28)
                            ? "You are eligible for military service."
                            : "You are not eligible for military service.";

        Console.WriteLine(message);
    }
    else if (firstOption == 3)
    {
        Console.Write("Enter first number, starting of the table:");
        long firstNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter last number, ending of the table:");
        long lastNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter inline first number:");
        long inlineFirstNumber = long.Parse(Console.ReadLine());

        Console.Write("Enter inline last number:");
        long inlineLastNumber = long.Parse(Console.ReadLine());
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
    else if (firstOption == 4)
    {
        Console.WriteLine("Thank you for using our app.");
    }
    else
    {
        Console.WriteLine("We have only three function, check and try again!!!");
    }

} while (firstOption != 4);