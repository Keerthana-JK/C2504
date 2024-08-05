//P6.Q2
//print the following pattern (using while loop)
//        5
//      5 4
//    5 4 3
//  5 4 3 2
//5 4 3 2 1

using System;

namespace Q2
{
    internal class Program
    {
        static void PrintNumTriangle(int N)
        {
            int I = 1;
            while (I <= N)
            {
                int J = 1;
                while(J <= N - I)
                {
                    Console.Write("  "); //2 spaces
                    J++;
                }
                J = 5;
                while (J > N - I)
                {
                    Console.Write($"{J} ");//num and space
                    J--;
                }
                Console.WriteLine();//new line
                I++;
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
            Console.WriteLine("-----Pattern printing using while-----");
            TestPrintNumTriangle();
            Console.WriteLine("-----End-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}