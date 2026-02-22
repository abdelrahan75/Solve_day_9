using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve_day_9_C_
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        public ComplexNumber(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) =>
            new ComplexNumber(a.Real + b.Real, a.Imag + b.Imag);

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) =>
            new ComplexNumber(
                a.Real * b.Real - a.Imag * b.Imag,
                a.Real * b.Imag + a.Imag * b.Real
            );

        public override string ToString() =>
            Imag >= 0 ? $"({Real} + {Imag}i)" : $"({Real} - {Math.Abs(Imag)}i)";
    }
}
