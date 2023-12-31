using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class CalculatoR : ICalculatoR
    {
        public decimal FirstNumber { get; set; }
        public string Option { get; set; }
        public decimal SecondNumber { get; set; }

        public CalculatoR(decimal firstNumber, string option, decimal secondNumber)
        {
            FirstNumber = firstNumber;
            Option = option;
            SecondNumber = secondNumber;
        }
        public CalculatoR(decimal firstNumber, string option)
        {
            FirstNumber = firstNumber;
            Option = option;
        }

        public void Calculate()
        {


            string template = $"{this.FirstNumber} {Option} {this.SecondNumber} =";

            Console.WriteLine("There are calculation process:");

            decimal result = CalculateValues(Option, this.FirstNumber, this.SecondNumber);

            if (Option.Equals("sqrt"))
                Console.WriteLine($"Root value of {this.FirstNumber} = {result}");
            else
                Console.WriteLine($"{template} {result}");

        }
        public decimal CalculateValues(string option, decimal firstNumber, decimal secondNumber)
        {
            return option switch
            {
                "+" => Sum(this.FirstNumber, this.SecondNumber),
                "-" => Subtract(this.FirstNumber, this.SecondNumber),
                "*" => Multiply(this.FirstNumber, this.SecondNumber),
                "/" => Divide(this.FirstNumber, this.SecondNumber),
                "%" => Modulo(this.FirstNumber, this.SecondNumber),
                "sqrt" => Root(this.FirstNumber),
                _ => 0
            };
        }

        public decimal Sum(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public decimal Modulo(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber % secondNumber;
        }

        public decimal Root(decimal number)
        {
            return (decimal)Math.Sqrt((double)number);
        }
    }
}