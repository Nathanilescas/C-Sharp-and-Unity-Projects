using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    class Employee<T> : Person, IQuittable
    {

        public List<T> thing { get; set; }



        // PART OF OPERATOR SUBMISSION ASSIGNMENT
        //public int id;

        //public static bool operator ==(Employee employee1, Employee employee2)
        //{
        //   if(employee1.id == employee2.id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    if(employee1.id != employee2.id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}



        public void Quit()
        {
            Console.WriteLine("Hello, World!");
        }

        public override void SayName()
        {
            base.SayName();
        }
    }
}
