using Calculator.Classes;
public class Program
{
    private static void Main(string[] args)
    {

        int firstOption = 0;
        do
        {
            ReporteR.ShowMenu();
            firstOption = ValueManipulatoR.ConvertInputOption();

            switch (firstOption)
            {
                case 1:
                    decimal firstNumber = ValueManipulatoR.GetInputByMessageToNumbers("Enter first number: ");
                    string option = ValueManipulatoR.GetInputByMessageToOptions("Option [+, -, *, /, %, sqrt]: ");
                    if(option == "sqrt")
                    {
                        var calculator = new AdvancedCalculator(firstNumber, option);
                        calculator.Calculate();
                        break;
                    }
                    else
                    {
                    decimal secondNumber = ValueManipulatoR.GetInputByMessageToNumbers("Enter second number: ");
                    var calculate = new AdvancedCalculator(firstNumber, option, secondNumber);
                    calculate.Calculate(); break;
                    }
                case 2: 
                    int age = ValueManipulatoR.GetInputByMessageToAge("Enter your age: ");
                    var eligibleAge = new EligibleAgeForArmy(age);
                    eligibleAge.CheckAgeEligibleForMilitaryService(); break;

                case 3: 
                    long firstNumberTable = ValueManipulatoR.GetInputByMessageToTable("Enter first number, starting of the table:");
                    long secondNumberTable = ValueManipulatoR.GetInputByMessageToTable("Enter last number, ending of the table:");
                    long inlineFirstNumberTable = ValueManipulatoR.GetInputByMessageToTable("Enter inline first number:");
                    long inlineLastNumberTable = ValueManipulatoR.GetInputByMessageToTable("Enter inline last number:");
                    var table = new MultiplicationTable(firstNumberTable, secondNumberTable, inlineFirstNumberTable, inlineLastNumberTable);
                    table.ShowMultiplicationTable(); break;

                case 4: ReporteR.ExitFromProgram(); break;
                default: ReporteR.DefaultCase(); break;
            }

        } while (firstOption != 4);

    }
}