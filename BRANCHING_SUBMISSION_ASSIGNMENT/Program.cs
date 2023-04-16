using System;

namespace BRANCHING_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50 )
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadKey();
            }else
            {
                Console.WriteLine("What is the width of the package?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of the package?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of the package?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                int packageTotal = packageWidth + packageHeight + packageLength;
                if (packageTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadKey();
                } else
                {
                    packageTotal = (packageWidth * packageLength * packageHeight * packageWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is : $" + packageTotal);
                    Console.ReadKey();
                }
            }



        }
    }
}
