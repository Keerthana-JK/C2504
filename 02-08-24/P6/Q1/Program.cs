//P6.Q1
//print the following pattern (using for loop)
//        5
//      5 4
//    5 4 3
//  5 4 3 2
//5 4 3 2 1

using System;

namespace Q1
{
    internal class Program
    {
        static void PrintNumTriangle(int N)
        {
            for (int I = 1; I <= N; I++)
            {
                for (int J = 1; J <= N - I; J++)
                {
                    Console.Write("  "); //2 spaces
                }
                for (int J = 5; J > N - I; J--)
                {
                    Console.Write($"{J} ");//num and space
                }
                Console.WriteLine();//new line 
            }
        }

        static void TestPrintNumTriangle()
        {
            Console.Write("Enter number of lines:");
            int N = int.Parse(Console.ReadLine());
            PrintNumTriangle(N);
        }
        static void Main(string[] args) //user: p
        {
            Console.WriteLine("-----Pattern printing using for loop-----");
            TestPrintNumTriangle();
            Console.WriteLine("-----End-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}