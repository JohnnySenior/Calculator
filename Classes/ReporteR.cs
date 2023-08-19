using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public static class ReporteR
    {
        public static void ShowMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Universal Calculator Application");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. Basic Calculator.");
            Console.WriteLine("2. Age Calculator");
            Console.WriteLine("3. Multiplication table");
            Console.WriteLine("4. Exit");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Choose option:");
            Console.ResetColor();
        }

        public static void ExitFromProgram()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Thank you for using our app.");
            Console.ResetColor();
        }

        public static void DefaultCase()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("We have only 4 options, check and try again!!!");
            Console.ResetColor();
        }
    }
}