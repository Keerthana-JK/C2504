//1.Write a program to find the highest number from 10 numbers.(user should input numbers)
//2. The highest number should be returned from a function , do exception handling , do unit testing.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exception_UnitTest_Highest
{
    public class Program
    {
        public static int FindHighestNum(int num, int highest)
        {   
            if(num>highest)
            {
                highest = num;
            }
            return highest;
        }
        static void Main(string[] args)
        {
            int highest = 0;
            Console.WriteLine("Enter numbers");
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    highest = FindHighestNum(num, highest);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }

            }
            Console.WriteLine(highest);
        }
    }
}
