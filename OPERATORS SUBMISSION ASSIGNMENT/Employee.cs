using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION_ASSIGNMENT
{
    public class Employee
    {
        public int ID;

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if(employee1.ID != employee2.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
