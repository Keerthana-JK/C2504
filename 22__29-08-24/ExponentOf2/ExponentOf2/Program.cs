using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentOf2
{
    internal class Program
    {
        public static int ExponentOf2(int n)
        {
            int power = 0;
            if (n <= 0)
            {
                throw new Exception("Entered number is less than or equal to zero");
            }
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is a power of 2");
                while (n >= 1)
                {
                    power++;
                    n = n / 2;
                }
                return power;
            }
            else
            {
                return -1;
            } 
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n=int.Parse(Console.ReadLine());
            int power=ExponentOf2(n);
            if (power != -1)
            {
                Console.WriteLine($"Exponent: {power-1}");
            }
        }
    }
}
