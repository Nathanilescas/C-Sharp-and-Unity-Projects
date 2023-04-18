using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONSOLE APP ASSIGNMENT PART ONE");

            Console.WriteLine("Type your top 5 friends.");
            string[] friends = new string[5];
            for (int i = 0; i < 5; i++)
            {

                friends[i] = Console.ReadLine();

            }
            Console.WriteLine("Your top five friends are : ");
            foreach (string name in friends)
            {
                Console.WriteLine("\n" + name);
            }
            Console.WriteLine("Hit enter to move on to the next assigment\n");
            Console.ReadKey();


            ////////////////////////////////////////////////////////////////////
            Console.WriteLine("CONSOLE APP ASSIGNMENT PART TWO");

            int whileCount = 1;
            while (true)
            {

                Console.WriteLine("This is the " + whileCount + " time this iteration has gone through.");
                whileCount++;

                // To fix this infinite loop it you could use a break or change the while conditon to false.
                if (whileCount > 10)
                {
                    break;
                }

            }
            Console.WriteLine("Hit enter to move on to the next assigment\n");
            Console.ReadKey();

            /////////////////////////////////////////////////////////////
            Console.WriteLine("CONSOLE APP ASSIGNMENT PART THREE");

            Console.WriteLine("Pick any number.");
            long chosenNum = Convert.ToInt64(Console.ReadLine());
            int iterationTime = 0;
            while (0 < chosenNum)
            {
                chosenNum = chosenNum / 100;
                iterationTime++;
            }
            Console.WriteLine("There was " + iterationTime + " iterations.");
            Console.ReadKey();

            int num1 = 5;
            while (num1 <= 100)
            {
                num1 += 10;
                Console.WriteLine("num1 is still <= 100");
            }
            Console.WriteLine("Hit enter to move on to the next assigment\n");
            Console.ReadKey();



            //////////////////////////////////////////////////////////
            Console.WriteLine("CONSOLE APP ASSIGNMENT PART FOUR");

            Console.WriteLine("Type in a name to see if it's on the list.");
            string name2Search = Console.ReadLine();
            int nameNotThere = 0;

            List<string> names = new List<string>();
            names.Add("Nathan");
            names.Add("Vu");
            names.Add("Castro");
            names.Add("Malana");
            names.Add("Joe");
            names.Add("Rodriguez");
            names.Add("Min");

            foreach(string name in names)
            {
                if(name == name2Search)
                {
                    Console.WriteLine(name + " is on the list!");
                    break;
                }
                else
                {
                    nameNotThere++;
                    if(nameNotThere == 7)
                    {
                        Console.WriteLine(name2Search + " is not on the list.");
                    }
               }
            }
            Console.WriteLine("Hit enter to move on to the next assigment\n");
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////
            Console.WriteLine("CONSOLE APP ASSIGNMENT PART FIVE");

            Console.WriteLine("Input a country's name.");
            string input = Console.ReadLine();

            List<string> countries = new List<string>();
            countries.Add("China");
            countries.Add("Turkey");
            countries.Add("Italy");
            countries.Add("France");
            countries.Add("Japan");
            countries.Add("Mexico");
            countries.Add("Iran");
            countries.Add("Mexico");
            countries.Add("United States");

            for(int i = 0; i < countries.Count; i++)
            {
                if (input == countries[i])
                {
                    Console.WriteLine("The index of the country is " + i);
                }
                else if (i + 1 == countries.Count && input != countries[i])
                {
                    Console.WriteLine(input + " is not there.");
                }
            }
            Console.WriteLine("Hit enter to move on to the next assigment\n");
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("CONSOLE APP ASSIGNMENT PART SIX");

            List<string> cities = new List<string>();
            cities.Add("Vista");
            cities.Add("Carlsbad");
            cities.Add("Oceanside");
            cities.Add("Encinitas");
            cities.Add("San Diego");
            cities.Add("La Jolla");
            cities.Add("Vista");
            cities.Add("Oceanside");
            cities.Add("Los Angeles");

            List<string> checkingList = new List<string>();

            foreach (string cityName in cities) // Creating a list to compare to the first one
            {
                checkingList.Add(cityName); 
            }

            for (int i = 0; i < checkingList.Count; i++) // This loop will go through the checkingList 
            {
               for (int j = i + 1; j < cities.Count; j++)
                {
                    if(checkingList[i] == cities[j]) // this will check if the indeces match, if so print to the console.
                    {
                        Console.WriteLine(checkingList[i] + " is on the list multiple times.");
                    }
                }
            }
            Console.ReadKey();


        }
    }
}
