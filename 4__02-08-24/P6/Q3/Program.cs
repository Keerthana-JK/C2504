//P6.Q3
//print the following pattern (using do-while loop)
//        5
//      5 4
//    5 4 3
//  5 4 3 2
//5 4 3 2 1

using System;

namespace Q3
{
    internal class Program
    {
        static void PrintNumTriangle(int N)
        {
            int I = 1;
            do
            {
                int J = 1;
                do
                {
                    Console.Write("  "); //2 spaces
                    J++;
                } while (J <= N - I);
                J = N;
                do
                {
                    Console.Write($"{J} ");//num and space
                    J--;
                } while (J > N - I);
                Console.WriteLine();//new line
                I++;
            } while (I <= N);
        }

        static void TestPrintNumTriangle()
        {
            Console.Write("Enter number of lines:");
            int N = int.Parse(Console.ReadLine());
            PrintNumTriangle(N);
        }
        static void Main(string[] args) //user: p
        {
            Console.WriteLine("-----Pattern printing using do-while-----");
            TestPrintNumTriangle();
            Console.WriteLine("-----End-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}