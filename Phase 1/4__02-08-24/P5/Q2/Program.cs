//P5.Q2
//print the N th term in the series 0, 1, 1, 2, 3, 5, 8, 13, ... N terms (using while loop)

using System;

namespace Q2
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int fib1 = 0;
            int fib2 = 1;
            int fib = 0;
            int i = 2;
            while(i <= n)
            {
                fib = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib;
                i++;
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