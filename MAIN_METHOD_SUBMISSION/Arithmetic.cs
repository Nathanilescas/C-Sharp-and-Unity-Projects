using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD_SUBMISSION
{
    class Arithmetic
    {
        public static int Addition(int num)
        {
            int num2 = num + 10;
            num2 = num2 + 2;
            return num2;
        }

        public static int Addition(float num)
        {
           float num2 = num + 20;
            num2 = num2 + 4;
            return  Convert.ToInt32(num2);
        }

        public static int Addition(string num)
        {
            int convertString = Convert.ToInt32(num);
            int num2 = convertString + 15;
            return num2;
        }
    }
}
