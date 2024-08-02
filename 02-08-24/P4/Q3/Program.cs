﻿//P4.Q3
//print series 0, 1, 1, 2, 3, 5, 8, 13, ... N terms (using do-while loop)

using System;

namespace Q1
{
    internal class Program
    {
        static void Fibonacci(int n)
        {
            int fib1 = 0;
            int fib2 = 1;
            int fib;
            Console.Write($"{fib1} {fib2}");
            int i = 0;
            do
            {
                fib = fib1 + fib2;
                Console.Write($" {fib}");
                fib1 = fib2;
                fib2 = fib;
                i++;
            } while (i < n);

        }
        static void TestFibonacci()
        {
            Console.Write("Enter number of terms required:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Series:");
            Fibonacci(n);
        }
        static void Main(string[] args)
        {
            TestFibonacci();
        }
    }
}
