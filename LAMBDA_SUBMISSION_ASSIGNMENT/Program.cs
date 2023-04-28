using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION_ASSIGNMENT
{
    public class Employee
    {
        public string firstName { get; set;}
        public string lastName { get; set;}
        public int id { get; set;}

        
    }

    class Program
    {
        
        static void Main(string[] args)
        {


            List<string> fName = new List<string>() { "Joe", "Nathan", "Hector", "Rodolfo", "Joe", "Justin", "Vu", "Andy", "Mark", "Eddie" };
            List<string> lName = new List<string>() { "Parker", "Ilescas", "Castillo", "Vargas", "Bennet", "Hugo", "Vu", "Castro", "Malana", "Morals" };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() {firstName = "Joe", lastName = "Parker", id = 1},
                new Employee() {firstName = "Nathan", lastName = "Ilescas", id = 2},
                new Employee() {firstName = "Hector", lastName = "Castillo", id = 3},
                new Employee() {firstName = "Rodolfo", lastName = "Vargaz", id = 4},
                new Employee() {firstName = "Joe", lastName = "Justin", id = 5},
                new Employee() {firstName = "Andy", lastName = "Nava", id = 6},
                new Employee() {firstName = "Andres", lastName = "Castro", id = 7},
                new Employee() {firstName = "Mark", lastName = "Malana", id = 8},
                new Employee() {firstName = "Eddie", lastName = "Moralas", id = 9},
                new Employee() {firstName = "Vu", lastName = "Vu", id = 10},
            };

            List<Employee> newList = new List<Employee>();
            foreach (Employee FN in employees)
            {
                if (FN.firstName == "Joe")
                {
                    newList.Add(FN);
                }
            }





            foreach (Employee employeeName in newList)
            {
                Console.WriteLine("Foreach Loop Way");
                Console.Write("First Name : " + employeeName.firstName);
                Console.Write(" ");
                Console.Write("Last Name : " + employeeName.lastName);
                Console.Write(" ");
                Console.Write("ID Number : " + employeeName.id);
                Console.Write("\n ");
                Console.WriteLine();
            }


            List<Employee> newList2 = new List<Employee>();
            newList2 = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employeeName in newList2)
            {
                Console.WriteLine("Lambda Expression way");
                Console.Write("First Name : " + employeeName.firstName);
                Console.Write(" ");
                Console.Write("Last Name : " + employeeName.lastName);
                Console.Write(" ");
                Console.Write("ID Number : " + employeeName.id);
                Console.Write(" ");
                Console.WriteLine();
            }

            Console.ReadKey();
            
            

        }
    }
}
