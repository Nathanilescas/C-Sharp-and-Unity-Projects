using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARSING_ENUMS_SUBMISSION_ASSIGNMENT
{
    class Program
    {

        public enum DaysOfTheWeek
        {
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7
        };
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the current day of the week");
            try
            {

                string input = Console.ReadLine();
                Days day = new Days();
                
            }
            catch(FormatException )
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
