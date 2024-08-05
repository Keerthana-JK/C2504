//P5.Q1
//print the N th term in the series 0, 1, 1, 2, 3, 5, 8, 13, ... N terms (using for loop)

using System;

namespace Q1
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int fib1 = 0;
            int fib2 = 1;
            int fib=0;
            int i = 0;
            for (i = 2; i <= n; i++)
            {
                fib = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib;

            }
            Console.Write($" {fib}");
            return fib;
        }

        static void TestFibonacci()
        {
            Console.Write("Enter number of terms required:");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n}th term :");
            Fibonacci(n);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            TestFibonacci();
        }
    }
}