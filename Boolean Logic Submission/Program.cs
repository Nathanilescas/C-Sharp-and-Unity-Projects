using System;


namespace Boolean_Logic_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance");
            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            Console.WriteLine("Have you ever had a DUI? Please type true or false.");
            input = Console.ReadLine();
            bool DUI = Convert.ToBoolean(input);
            Console.WriteLine("How many speeding tickets do you have?");
            input = Console.ReadLine();
            int tickets = Convert.ToInt32(input);

            if ((age > 15) && (DUI != true) && (tickets <= 3))
            {
                Console.WriteLine("You Qualify!!");
            }else
            {
                Console.WriteLine("You don't qualify.");
            }
            Console.ReadKey();
        }
    }
}
