using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class MultiplicationTable
    {
        public MultiplicationTable(long firstNumber, long lastNumber, long inlineFirsNumber, long inlineLastNumber)
        {
            FirstNumber = firstNumber;
            LastNumber = lastNumber;
            InlineFirstNumber = inlineFirsNumber;
            InlineLastNumber = inlineLastNumber;
        }

        public long FirstNumber { get; set; }
        public long LastNumber { get; set; }
        public long InlineFirstNumber { get; set; }
        public long InlineLastNumber { get; set; }

        public void ShowMultiplicationTable()
        {
            // long firstNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter first number, starting of the table:");
            // long lastNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter last number, ending of the table:");
            // long inlineFirstNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter inline first number:");
            // long inlineLastNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter inline last number:");
            // Console.Clear();

            for (long iteration = FirstNumber; iteration <= LastNumber; iteration++)
            {
                Console.WriteLine("******************************");

                for (long inlineIteration = InlineFirstNumber; inlineIteration <= InlineLastNumber; inlineIteration++)
                {
                    Console.WriteLine($"{iteration} * {inlineIteration} = {iteration * inlineIteration}");
                }
            }
        }

    }
}