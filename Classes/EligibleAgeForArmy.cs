using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    public class EligibleAgeForArmy
    {
        public int Age { get; set; }

        public EligibleAgeForArmy(int age)
        {
            Age = age;
        }

        public void CheckAgeEligibleForMilitaryService()
        {
            string message = (Age >= 18 && Age < 28)
                                ? "You are eligible for military service."
                                : "You are not eligible for military service.";

            Console.WriteLine(message);
        }
    }
}