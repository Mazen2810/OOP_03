using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part01_Q5
{
     class BaseClass
    {

        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }

    class DerivedClass1 : BaseClass
    {

        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }

    class DerivedClass2 : DerivedClass1
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
}
