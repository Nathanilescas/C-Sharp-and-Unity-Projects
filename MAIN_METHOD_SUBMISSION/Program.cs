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


            Arithmetic firstOp = new Arithmetic();
            Console.WriteLine(firstOp.Addition(5));

            Arithmetic secondOp = new Arithmetic();
            Console.WriteLine(secondOp.Addition(5.5m));

            Arithmetic thirdOp = new Arithmetic();
            Console.WriteLine(thirdOp.Addition("5"));

            

            Console.ReadKey();

            ///////////////////////////////////////////////////////////
            // METHOD SUBMISSION ASSIGNMENT//

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
            Console.ReadKey();
        }
    }
}
