using System;

namespace Calculator
{
    class Calculator
    {
        private int a;
        private int b;
        private Calculator()
        {
            a = 0;
            b = 0;
        }
        private Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        private int Sum()
        {
            return a + b;
        }
        private int Diff()
        {
            return a - b;
        }
        private int Multiply()
        {
            return a * b;
        }
        private int Divide()
        {
            return a / b;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Calculator calc = new Calculator(20, 10);
                Console.WriteLine($"Sum: {calc.Sum()}, Difference: {calc.Diff()}, Multiplication: {calc.Multiply()}, Division: {calc.Divide()}");
                Console.Clear();
            }
        }
    }
}
