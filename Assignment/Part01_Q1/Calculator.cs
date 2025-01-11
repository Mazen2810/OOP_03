using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part01_Q1
{
    internal class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public  int Sum(int X , int Y )
        {
            return X + Y;
        }
        public  int Sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        public  double Sum(double X, double Y)
        {
            return X + Y;
        }
    }
}
