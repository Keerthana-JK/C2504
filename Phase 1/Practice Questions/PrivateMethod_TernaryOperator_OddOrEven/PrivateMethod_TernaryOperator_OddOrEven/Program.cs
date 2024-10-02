using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateMethod_TernaryOperator_OddOrEven
{
    internal class Program
    {
        public static string OddOrEven(int num)
        {
            return num % 2 == 0 ? "Even" : "Odd";
        }
        private static void StoreOddOrEvenResult(int num)
        {
            string result = OddOrEven(num);
            int resultAsInt = result == "Even" ? 0 : 1;
            //Console.WriteLine(resultAsInt);
        }
        static void Main(string[] args)
        {
            int number = 5;
            string result = OddOrEven(number);
            Console.WriteLine($"The number {number} is {result}.");

            // Example usage of StoreOddOrEvenResult method
            StoreOddOrEvenResult(number);

        }
    }
}
