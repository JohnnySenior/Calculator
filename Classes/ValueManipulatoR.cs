using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public static class ValueManipulatoR
    {
        public static int ConvertInputOption()
        {

            int firstOption = 0;
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                firstOption = int.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.Clear();
            }
            catch (FormatException formatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The input is not in a correct format");
                Console.ResetColor();
            }
            catch (OverflowException overflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value is too large or too small, take a look data type.");
                Console.ResetColor();
            }
            catch (Exception exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exception.Message);
                Console.ResetColor();
            }

            return firstOption;
        }

        public static decimal GetInputByMessageToNumbers(string message)
        {
            Console.Write(message);
            decimal result;

            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
                Console.ResetColor();
                Console.Write(message);
            }

            return result;
        }
        public static string GetValidOperation(string message)
        {
            string result;

            do
            {
                Console.Write(message);
                result = Console.ReadLine();

                if (!IsValidOperation(result))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation. Please choose from +, -, *, /, %, sqrt.");
                    Console.ResetColor();
                }
            } while (!IsValidOperation(result));

            return result;
        }

        public static bool IsValidOperation(string input)
        {
            string[] validOperations = { "+", "-", "*", "/", "%", "sqrt" };
            return validOperations.Contains(input);
        }



        public static int GetInputByMessageToAge(string message)
        {
            Console.Write(message);
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
                Console.ResetColor();
                Console.Write(message);
            }

            return result;
        }

        public static long GetInputByMessageToTable(string message)
        {
            Console.Write(message);
            long result;

            while (!long.TryParse(Console.ReadLine(), out result))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
                Console.ResetColor();
                Console.Write(message);
            }

            return result;
        }
    }
}