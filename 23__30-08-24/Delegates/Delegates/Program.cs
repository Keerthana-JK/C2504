using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegates
{
    public delegate void Operation(int n1, int n2);
    internal class Program
    {
        public static void Add(int a, int b) => Console.WriteLine(a + b);
        public static void Sub(int a, int b) => Console.WriteLine(a - b);
        public static void Mul(int a, int b, int c) => Console.WriteLine(a * b * c);
        static void Main(string[] args)
        {
            Operation op = Add;
            op += Sub;//5
            op += Sub;//5 (same result gets repeated)
            op -= Sub;//not gets printed
            Thread.Sleep(1000);
            op(10, 5);//15
        }
    }
}
