using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT_CLASS_SUBMISSION
{
    class Employee : Person, IQuittable
    {
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
