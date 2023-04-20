using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class DivOperations
    {
        public void Div(int num1,out int num2)
        {
            num2 = num1 / 2;
        }

        public void Div(int num1)
        {
            num1 = (num1 / 2) - 1;
        }

        public static int MathOp(int num1)
        {
            num1 = (num1 * 10) / 2;
            return num1;
        }
    }
}
