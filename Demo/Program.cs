
using Demo.Operator_Overloading;
namespace Demo
{
    internal class Program
    {
        static int sum(int X, int Y)
        {
            return X + Y;
        }

        static double sum(double X, double Y)
        {
            return X + Y;
        }
        static int sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        static double sum(int X, double Y)
        {
            return X + Y;
        }
        static void Main(string[] args)
        {

            #region OOP Pillars 3. PolyMorphism 1. Overloading
            //dynamic result = sum(2.2, 2.2);
            //result = sum(1, 2, 3);

            //Console.WriteLine($"Result = {result}");

            //Console.WriteLine("Ahmed");
            //Console.WriteLine("A");
            //Console.WriteLine(10);
            //Console.WriteLine(true);

            //Console.WriteLineString();
            //Console.WriteLineChar();
            //Console.WriteLineInt();
            //Console.WriteLineBoolean(); 
            #endregion
            Complex C1 = new Complex() { Real = 2, Imag = 4 };
            Complex C2 = new Complex() { Real = 2, Imag = 4 };

            #region Operators Overloading - Binary Operators


            //Complex C3;

            //C3 = C1 + C2;

            //// C2 += C1  ===> C2 = C2 + C1
            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C1 = {C2}");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine($"C1 = {C3}");
            #endregion

            #region Unary Operators

            //Console.WriteLine($"C1 = {C1}");

            //Complex C3 = ++C1; Console.WriteLine("After ++C1");

            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C3 = {C3}");
            #endregion
        }
    }
}
