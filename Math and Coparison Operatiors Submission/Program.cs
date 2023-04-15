using System;


namespace Math_and_Coparison_Operatiors_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1 : ");
            Console.WriteLine("Hourly Rate?");
            string input = Console.ReadLine();
            int rateP1 = Convert.ToInt32(input);
            Console.WriteLine("Hours worked per week?");
            input = Console.ReadLine();
            int hoursP1 = Convert.ToInt32(input);

            Console.WriteLine("Person 2 : ");
            Console.WriteLine("Hourly Rate?");
            input = Console.ReadLine();
            int rateP2 = Convert.ToInt32(input);
            Console.WriteLine("Hours worked per week?");
            input = Console.ReadLine();
            int hoursP2 = Convert.ToInt32(input);

            Console.WriteLine("Annual Salary of Person 1 :" + "\n" + ((hoursP1*52)*rateP1));
            Console.WriteLine("Annual Salary of Person 2 :" + "\n" + ((hoursP2 * 52) * rateP2));
            Console.ReadKey();

        }
    }
}
