using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part01_Q2
{
    internal class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            
        }
        public Rectangle(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public Rectangle(int Length)
        {
            this.Width = this.Height = Length;

        }
    }
}
