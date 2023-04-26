using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Employee();
            employee1.id = 01;
            employee1.firstName = "Nathan";
            employee1.lastName = "Ilescas";
            employee1.SayName();

            Employee employee2 = new Employee();
            employee2.id = 02;

            IQuittable employee3 = new Employee();
            
            employee3.Quit();


            // OPERATOR SUBMISSION ASSIGNMENT
            Console.WriteLine((employee1 == employee2) ? "Employee #1 is Equal to Employee #2" : "Employee #1 is Not equal to Employee #2");

            Console.ReadKey();

            
        }
    }
}
