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
            Console.WriteLine(Arithmetic.Addition(3)); // Int Method

            Console.WriteLine(Arithmetic.Addition(5.5f)); // Float Method

            Console.WriteLine(Arithmetic.Addition("10")); // String Method

            Console.ReadKey();
        }
    }
}
