using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to perform an operation on.");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Arithmetic.Add(input));
            Console.WriteLine(Arithmetic.Sub(input));
            Console.WriteLine(Arithmetic.Div(input));
            Console.ReadKey();
        }
    }
}
