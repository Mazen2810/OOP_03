using System.Drawing;
using Assignment.Part01_Q1;
using Assignment.Part01_Q2;
using Assignment.Part01_Q3;
using Assignment.Part01_Q4;
using Assignment.Part01_Q5;
using Assignment.Part02;


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


            #region Part 02

            #region Q3:Define All Required Constructors to Produce this output:
            Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString()); // Hours: 1, Minutes :10, Seconds :15

            //Console.WriteLine("----------------------");

            Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString()); // Hours: 1, Minutes :0, Seconds :0

            //Console.WriteLine("----------------------");


            Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString()); // Hours: 2, Minutes :10, Seconds :0
            //Console.WriteLine("----------------------");

            Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString()); // Minutes: 11, Seconds: 6 
            #endregion

            #region Q4: Implement All required Operators overloading to enable this Code
            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3 = --D2;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //bool flag = (D1 > D2);
            //Console.WriteLine(flag);

            //bool flag = (D1 <= D2);
            //Console.WriteLine(flag);


            //if (D1)
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");

            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);



            #endregion


            #endregion
        }
    }
}
