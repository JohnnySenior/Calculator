using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class CalculatoR
    {
        public void Calculate()
        {
            string firstUserValue = ValueManipulatoR.GetInputByMessage("Enter first number: ");
            string option = ValueManipulatoR.GetInputByMessage("Option [+, -, *, /, %]: ");
            string secondUserValue = ValueManipulatoR.GetInputByMessage("Enter second number: ");
            Console.Clear();

            decimal firstNumber = ValueManipulatoR.ConvertValueToDecimal(firstUserValue);
            decimal secondNumber = ValueManipulatoR.ConvertValueToDecimal(secondUserValue);

            string template = $"Add: {firstNumber} {option} {secondNumber} =";

            Console.WriteLine("There are calculation process:");

            decimal result = CalculateValues(option, firstNumber, secondNumber);

            Console.WriteLine($"{template} {result}");
        }

        public void CheckAgeEligibleForMilitaryService()
        {
            string stringAge = ValueManipulatoR.GetInputByMessage("Enter your age: ");
            int age = int.Parse(stringAge);
            Console.Clear();

            string message = (age >= 18 && age < 28)
                                ? "You are eligible for military service."
                                : "You are not eligible for military service.";

            Console.WriteLine(message);
        }

        public void MultiplicationTable()
        {
            long firstNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter first number, starting of the table:");
            long lastNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter last number, ending of the table:");
            long inlineFirstNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter inline first number:");
            long inlineLastNumber = ValueManipulatoR.ConvertValueByShowMessage("Enter inline last number:");
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

        public decimal CalculateValues(string option, decimal firstNumber, decimal secondNumber)
        {
            return option switch
            {
                "+" => Sum(firstNumber, secondNumber),
                "-" => Subtract(firstNumber, secondNumber),
                "*" => Multiply(firstNumber, secondNumber),
                "/" => Divide(firstNumber, secondNumber),
                "%" => Modulo(firstNumber, secondNumber),
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

    }
}