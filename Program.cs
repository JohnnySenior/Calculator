using Calculator.Classes;
public class Program
{
    private static void Main(string[] args)
    {
        var calculate = new CalculatoR();
        int firstOption = 0;
        do
        {
            ReporteR.ShowMenu();
            firstOption = ValueManipulatoR.ConvertInputOption();

            switch (firstOption)
            {
                case 1: calculate.Calculate(); break;
                case 2: calculate.CheckAgeEligibleForMilitaryService(); break;
                case 3: calculate.MultiplicationTable(); break;
                case 4: ReporteR.ExitFromProgram(); break;
                default: ReporteR.DefaultCase(); break;
            }

        } while (firstOption != 4);

    }
}