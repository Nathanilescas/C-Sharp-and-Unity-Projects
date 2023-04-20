using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            DivOperations divBy2 = new DivOperations();

            Console.WriteLine("Input a number to use on the method.");
            int convertNumber = Convert.ToInt32(Console.ReadLine());

            int output;
            divBy2.Div(convertNumber,out output);
            Console.WriteLine(output);


            DivOperations divOp = new DivOperations();
            divOp.Div(10);

            DivOperations.MathOp(10);
        }
    }
}
