using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("METHOD CLASS SUBMISSION ASSIGNMENT #1");

            Arithmetic firstOp = new Arithmetic();
            Console.WriteLine(firstOp.Addition(5));

            Arithmetic secondOp = new Arithmetic();
            Console.WriteLine(secondOp.Addition(5.5m));

            Arithmetic thirdOp = new Arithmetic();
            Console.WriteLine(thirdOp.Addition("5"));


            //////////////////////////////////////////////////
            Console.WriteLine("METHOD SUBMISSION ASSIGNMENT #2");

            Console.WriteLine("Input a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number (Optional)");
            string num2 = Console.ReadLine();
            int convertNum2;

            if (num2 != "")
            {
                convertNum2 = Convert.ToInt32(num2);
                Console.WriteLine(Arithmetic.Operation(num1, convertNum2));
            }
            else
            {
                Console.WriteLine(Arithmetic.Operation(num1));
            }


            //////////////////////////////////////////////////////////
            Console.WriteLine("METHOD CLASS SUBMISSION ASSIGNMENT #3"); 

            Arithmetic methodOp = new Arithmetic();
            methodOp.Ops(5, 10);
            methodOp.Ops(num1: 10, num2: 20);

            Console.ReadKey();
        }
    }
}
