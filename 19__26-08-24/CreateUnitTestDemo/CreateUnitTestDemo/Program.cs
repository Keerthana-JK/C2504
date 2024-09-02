using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateUnitTestDemo
{
    public class Calc
    {
        public double Multiply(double first, double second)
        {
            return first * second;
        }
        public double Divide(double first, double second)
        {
            return first / second;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Calc calc = new Calc();
                calc.Multiply(1, 2);
                calc.Divide(10, 2);
            }
        }
    }
}
