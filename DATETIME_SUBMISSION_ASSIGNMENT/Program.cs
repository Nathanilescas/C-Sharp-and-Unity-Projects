using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DATETIME_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            Console.WriteLine("Input a number of hours.");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("It will be " + currentTime.AddHours(input) + " in " + input + " hours.");
            Console.ReadKey();
            
        }
    }
}
