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

            return firstOption;
        }

        public static decimal GetInputByMessageToNumbers(string message)
        {
            Console.Write(message);
            return decimal.Parse(Console.ReadLine());
        }
        public static string GetInputByMessageToOptions(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int GetInputByMessageToAge(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static long GetInputByMessageToTable(string message)
        {
            Console.Write(message);
            return long.Parse(Console.ReadLine());
        }
    }
}