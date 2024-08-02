﻿//P2.Q1
//Print Nth term of the series 21 22 24 27 31 36 42 49...using for loop

using System;

namespace Q1
{
    internal class Program
    {
        //21_22_24_27_31_36_42_49
        static int GetNthTerm_21_22_24_27(int N)
        {
            int term = 21;
            int difference = 1;
            for (int I = 1; I <= N; I++)
            {
                if (I == N)
                {
                    break;
                }
                //
                term = term + difference;
                difference = difference + 1;
            }
            return term;
        }

        //input=5,output=31
        //input=3,output=24
        //input=7,output=42
        static void TestGetNthTerm_21_22_24_27()
        {
            Console.Write("Enter number of terms:");
            int N = int.Parse(Console.ReadLine());
            int nthTerm = GetNthTerm_21_22_24_27(N);
            Console.WriteLine($"Nth term is {nthTerm}");
        }
        static void Main(string[] args) //user: p
        {
            Console.WriteLine("-----TestGetNthTerm_21_22_24_27-----");
            TestGetNthTerm_21_22_24_27();
            Console.WriteLine("-----End TestGetNthTerm_21_22_24_27-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}
