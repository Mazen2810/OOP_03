using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part01_Q4
{
     class Employee
    {
        public virtual void work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    class Manager : Employee
    {
        public override void work()
        {
            base.work();
            Console.WriteLine("Manager is managing");
        }
    }

}
