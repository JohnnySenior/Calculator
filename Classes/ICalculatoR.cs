using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    internal interface ICalculatoR
    {
        void Calculate();
        decimal CalculateValues(string option, decimal firstNumber, decimal secondNumber);

        decimal Sum(decimal firstNumber, decimal secondNumber);

        decimal Subtract(decimal firstNumber, decimal secondNumber);

        decimal Multiply(decimal firstNumber, decimal secondNumber);

        decimal Divide(decimal firstNumber, decimal secondNumber);

        decimal Modulo(decimal firstNumber, decimal secondNumber);

        decimal Root(decimal number);
    }
}
