using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class AdvancedCalculator : CalculatoR
    {
        public AdvancedCalculator(decimal firstNumber, string option, decimal secondNumber)
         : base(firstNumber, option, secondNumber)
        {
        }
        public AdvancedCalculator(decimal firstNumber, string option)
         : base(firstNumber, option)
        {
        }

        public decimal Sqrt(decimal number)
        {
            return (decimal)Math.Sqrt((double)number);
        }
        public override void Calculate()
        {
            if (Option == "sqrt")
            {
                decimal result = Sqrt(this.FirstNumber);
                Console.WriteLine($"Square root of {this.FirstNumber} = {result}.");
            }
            else
            {
                base.Calculate();
            }
        }
    }
}