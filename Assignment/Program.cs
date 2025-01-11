using System.Drawing;
using Assignment.Part01_Q1;
using Assignment.Part01_Q2;
using Assignment.Part01_Q3;
using Assignment.Part01_Q4;
using Assignment.Part01_Q5;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q1: Write a class named Calculator that contains a method named Add
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Sum(10, 20));
            //Console.WriteLine(calc.Sum(10, 20, 30));
            //Console.WriteLine(calc.Sum(10.1, 20.2));





            #endregion

            #region Q2: Create a class named Rectangle with the following constructors
            //Part01_Q2.Rectangle rec1 = new Part01_Q2.Rectangle();  // Named the path to avoid confusion between system.rectangle and  Part01_Q2.Rectangle 
            //Part01_Q2.Rectangle rec2 = new Part01_Q2.Rectangle(10,20);
            //Part01_Q2.Rectangle rec3 = new Part01_Q2.Rectangle(30);
            #endregion

            #region Q3: Define a class Complex Number that represents a complex number with real and imaginary parts.
            //Complex C1 = new Complex() { Real = 4 , Imag = 6};
            //Complex C2 = new Complex() { Real = 6, Imag = 2 };

            //Console.WriteLine(C1-C2);
            //Console.WriteLine(C2+C1);

            #endregion


            #region Q4: Create a base class named Employee with method Work those prints "Employee is working"
            //Employee emp = new Manager();

            //emp.work();

            #endregion


            #region Q5: Create a base class BaseClass with a virtual method DisplayMessage that prints "Message from BaseClass"
            // Override : it makes Dynamic binding between Parent and child, that bind based on object not reference.
            // new : it makes a static binding between parent and child,  that bind based on reference not object

            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage(); // Message from BaseClass

            //Console.WriteLine("----------------------");


            // baseClass = new DerivedClass1();
            //baseClass.DisplayMessage(); // Message from DerivedClass1

            //Console.WriteLine("----------------------");

            // baseClass = new DerivedClass2();
            //baseClass.DisplayMessage(); //Message from DerivedClass1 [From the Parent class because the reference doesn't see the new function.]

            #endregion
            #endregion
        }
    }
}
