//P3.Q3
//print the following pattern (using do-while loop)
//        1
//      1 2
//    1 2 3
//  1 2 3 4
//1 2 3 4 5

using System;

namespace Q1
{
    internal class Program
    {
        static void PrintNumTriangleMirroredRightAngle(int N)
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
                J = 1;
                do
                {
                    Console.Write($"{J} ");//num and space
                    J++;
                } while (J <= I);
                Console.WriteLine();//new line 
                ; I++;
            }while (I <= N);
        }
        //input=4,output=4 lines triangle 
        //input=5,output=5 lines triangle 
        //input=7,output=7 lines triangle 
        static void TestPrintNumTriangleMirroredRightAngle()
        {
            Console.Write("Enter number of lines:");
            int N = int.Parse(Console.ReadLine());
            PrintNumTriangleMirroredRightAngle(N);
        }
        static void Main(string[] args) //user: p
        {
            Console.WriteLine("-----TestPrintNumTriangleMirroredRightAngle-----");
            TestPrintNumTriangleMirroredRightAngle();
            Console.WriteLine("-----End TestPrintNumTriangleMirroredRightAngle-----");
            Console.WriteLine("Press any key to contine...");
            Console.ReadKey();
        }
    }
}

