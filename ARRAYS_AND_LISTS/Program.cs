using System;
using System.Collections.Generic;

namespace ARRAYS_AND_LISTS
{
    class Program
    {
        static void Main()
        {
            // 1.) Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

            // create an array with 5 index
            string[] names = { "Nathan", "Noemi", "Eddie", "Castro", "Malana" };
            // user input then convert it to a int
            Console.WriteLine("Pick a number between 1-5 to display a name.");
            int pickedNum = Convert.ToInt32(Console.ReadLine());

            if (pickedNum >= 1 && pickedNum <= 5)
            {
                // cwl(array [with the user input as the number])
                Console.WriteLine(names[pickedNum - 1]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 1 and 5!");            
            }



            // 2.) Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] randomNum = new int[5];
            randomNum[0] = 20;
            randomNum[1] = 32;
            randomNum[2] = 49;
            randomNum[3] = 20;
            randomNum[4] = 67;

            Console.WriteLine("Pick a number between 1 and 5.");
            int numberPicked = Convert.ToInt32(Console.ReadLine());

            if (numberPicked >= 1 && numberPicked <= 5)
            {
                // cwl(array [with the user input as the number])
                Console.WriteLine(randomNum[numberPicked - 1]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 1 and 5!");
            }


            // Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
            List<string> moreNames = new List<string>();
            moreNames.Add("Rafa");
            moreNames.Add("Paola");
            moreNames.Add("Mutsi");
            moreNames.Add("Hector");
            moreNames.Add("Rodolfo");

            Console.WriteLine("Pick a number between 1 and 5");
            int listPickNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(moreNames[listPickNum-1]);
            Console.ReadKey();
        }
    }
}
