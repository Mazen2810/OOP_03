using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operators Overloading

        // Overloading Operator: Must be Non-Private Class Member Function
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0),
            };
            // Left?.Real
            // Left != null? Left.Real : null
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0),
            };
        }
        #endregion
        #region Binary Operators


        public static Complex operator ++(Complex C)
        {
            return new Complex
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        #endregion

        #region Relational Operators

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
            {
                return Left?.Imag > Right?.Imag;

            }
            else
                return Left?.Real > Right?.Real;

        }

        public static bool operator < (Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
            {
                return Left?.Imag < Right?.Imag;

            }
            else
                return Left?.Real < Right?.Real;

        }
        #endregion


        #region Casting Operators Overloading
        // Overloading casting operator: Create Non-Private class member Function

        public static /*int*/ explicit operator int (Complex C)
        {
            return C?.Real ?? 0;
        }
        public static /*string*/ explicit operator string (Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }
        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
