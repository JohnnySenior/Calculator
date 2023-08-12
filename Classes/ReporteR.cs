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
            Console.WriteLine("Universal Calculator Application");
            Console.WriteLine("1. Basic Calculator.");
            Console.WriteLine("2. Age Calculator");
            Console.WriteLine("3. Multiplication table");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option:");
        }

        public static void ExitFromProgram()
        {
            Console.WriteLine("Thank you for using our app.");
        }

        public static void DefaultCase()
        {
            Console.WriteLine("We have only three function, check and try again!!!");
        }
    }
}