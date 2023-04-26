using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() {ID = 01};
            Employee employee2 = new Employee() {ID = 02};

            Console.WriteLine((employee1.ID == employee2.ID) ? "Both are equal" : "Not equal");
            Console.ReadKey();
        }
    }
}
