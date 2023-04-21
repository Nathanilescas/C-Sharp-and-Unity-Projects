using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() {firstName = "Sample", lastName = "Student"};
            employee1.SayName();
            Console.ReadKey();
        }
    }
}
