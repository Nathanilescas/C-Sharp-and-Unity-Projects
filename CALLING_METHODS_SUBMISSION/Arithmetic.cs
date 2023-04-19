using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION
{
    class Arithmetic
    {
        public static int Add(int num)
        {
            int addTotal = num + 10;
            return addTotal;
        }

        public static int Sub(int num)
        {
            int subTotal = num - 10;
            return subTotal;
        }

        public static int Div(int num)
        {
            int DivTotal = num / 5;
            return DivTotal;
        }
    }
}
