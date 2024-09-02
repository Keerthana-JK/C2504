//Write a function in C# that takes an integer as input
//checks whether the number is positive, negative, or zero.
//The function should return "Positive" if the number is greater than zero,
//"Negative" if the number is less than zero, and
//"Zero" if the number is equal to zero.
//Demonstrate the function by passing different integers and displaying the corresponding return value.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition_Num_PosNegZero
{
    internal class Program
    {
        public static string Number(int n)
        {
            if(n>0)
            {
                return "Positive";
            }
            else if(n<0)
            {
                return "Negative";
            }
            else
            {
                return "Zero";
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be checked");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(Number(n)); 
        }
    }
}
