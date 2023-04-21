using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void SayName()
        {
            Console.WriteLine("Name : " + this.firstName + " " + this.lastName);
        }
    }
}
