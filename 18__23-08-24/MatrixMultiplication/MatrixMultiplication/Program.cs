using System;

namespace MatrixAddition
{
    internal class Program
    {
        public static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j] +"\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int rowsA = 3, colsA = 2;
            int rowsB = 2, colsB = 3;
            int[,] m1 = new int[ rowsA, colsA]
            {
                { 1,2 },
                { 4,5 },
                { 7,8 },
            };

            int[,] m2 = new int[rowsB, colsB]
            {
                { 1,2,3 },
                { 4,5,6 },
            };

            int[,] m3 = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    m3[i, j] = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        m3[i, j] = m1[i, k] * m2[k, j];
                    }
                }
            }

            PrintMatrix(m3, rowsA, colsB);
        }
    }
}
