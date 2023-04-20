using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION
{
    class Arithmetic
    {
        // MAIN METHOD SUBMISSION ASSIGNMENT //

        public int Addition(int num)
        {
            int num2 = num + 10;
            num2 = num2 + 2;
            return num2;
        }

        public int Addition(decimal num)
        {
            num = num + 10;
            int convertDec = Convert.ToInt32(num);
            return convertDec;
        }

        public int Addition(string num)
        {
            int convertString = Convert.ToInt32(num);
            int num2 = convertString + 15;
            return num2;
        }

        ///////////////////////////////////////////////
        /// METHOD SUBMISSION ASSIGNMENT #2 ///
        public static int Operation(int num, int num2 = 0)
        {
            int total = num + num2;
            return total;
        }

        ///////////////////////////////////////////////
        /// METHOD CLASS SUBMISSION ASSIGNMENT # 3////
        
        public void Ops(int num1, int num2)
        {
            num1 = num1 *  10;
            Console.WriteLine(num2);
        }

    }
}
