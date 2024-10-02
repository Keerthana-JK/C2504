using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleAnd2DArray
{
    //mark of students using array (no class)
    //store 3 marks of an student(2,3,4)
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D array
            int[,] studentMarks = {
                { 80, 70, 90 },
                { 90, 80, 70 },
                { 70, 90, 80 },
                { 85, 75, 95 },
                { 95, 85, 75 }
            };

            //Tuple
            var studMarks = new (int English, int Malayalam, int Physics)[]
            {
                (80, 70, 90),
                (90, 80, 70),
                (70, 90, 80),
                (85, 75, 95),
                (95, 85, 75)
            };

            foreach (var marks in studMarks)
            {
                Console.Write($"{marks.English} ");
                Console.Write($"{marks.Malayalam} ");
                Console.WriteLine($"{marks.Physics} ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " marks:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(studentMarks[i, j] + " ");
                }
                Console.WriteLine();
            }

        }


    }
}
