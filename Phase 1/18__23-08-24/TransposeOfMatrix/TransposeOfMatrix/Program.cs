using System;

namespace TransposeOfMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3,3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            int[,] transpose = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    transpose[i,j] = a[j,i];
                }
            }

            for(int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.Write(transpose[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
