using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Add(params int[] numbers)   
        {
            foreach (int number in numbers) //(using int)
                Console.WriteLine(number);

        }

        // Method using the params keyword with object type 
        static void PrintItems(params object[] items)
        {
            foreach (var item in items) //(using var)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calling method with different numbers of arguments");
            // Calling method with different numbers of arguments
            Add(1, 2);
            Add(1, 2, 5);
            Add(1, 2, 5, 9);
            Console.WriteLine("Calling the method with different types of arguments");
            // Calling the method with different types of arguments
            PrintItems(1, "Hello", 3.14, true);

        }
    }
}
