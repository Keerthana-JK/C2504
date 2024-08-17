//4.ComplexNumber { Real: int, Imaginary: int}
//-ComplexNumber Add(ComplexNumber other)
//    TestComplexNumber for addition 
//        (3 + i4)
//     +  (5 + i3) 
//     =  (8 + i7)

using System;

namespace ComplexNumberAddition
{
    class ComplexNumber
    {
        private int Real { get; set; }
        private int Imaginary { get; set;}

        public ComplexNumber(int Real, int Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;
        }
        public string Add(ComplexNumber other)
        {
             Real = this.Real + other.Real;
             Imaginary = this.Imaginary + other.Imaginary;
            return $"{ Real} + { Imaginary}i";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber cn1 = new ComplexNumber(10, 9);
            ComplexNumber cn2 = new ComplexNumber(20, 6);
            Console.WriteLine(cn2);
            Console.WriteLine(cn1.Add(cn2));
        }
    }
}
