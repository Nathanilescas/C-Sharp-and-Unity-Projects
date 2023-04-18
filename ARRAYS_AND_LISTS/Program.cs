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
            Console.WriteLine("Pick a number between 0 and 4 to display a name.");
            int pickedNum = Convert.ToInt32(Console.ReadLine());

            if (pickedNum >= 0 && pickedNum < 5)
            {
                // cwl(array [with the user input as the number])
                Console.WriteLine(names[pickedNum]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 4!");            
            }



            // 2.) Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] randomNum = new int[5];
            randomNum[0] = 20;
            randomNum[1] = 32;
            randomNum[2] = 49;
            randomNum[3] = 20;
            randomNum[4] = 67;

            Console.WriteLine("Pick a number between 0 and 4.");
            int numberPicked = Convert.ToInt32(Console.ReadLine());

            if (numberPicked >= 0 && numberPicked < 5)
            {
                // cwl(array [with the user input as the number])
                Console.WriteLine(randomNum[numberPicked]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 4!");
            }


            // Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
            List<string> moreNames = new List<string>();
            moreNames.Add("Rafa");
            moreNames.Add("Paola");
            moreNames.Add("Mutsi");
            moreNames.Add("Hector");
            moreNames.Add("Rodolfo");

            Console.WriteLine("Pick a number between 0 and 4");
            int listPickNum = Convert.ToInt32(Console.ReadLine());

            if (listPickNum >=0 && listPickNum < 5)
            {
                Console.WriteLine(moreNames[listPickNum]);
            }
            else
            {
                Console.WriteLine("You did not pick a number between 0 and 4!");
            }
            Console.ReadKey();
        }
    }
}
