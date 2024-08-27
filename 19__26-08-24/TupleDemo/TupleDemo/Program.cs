using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleDemo
{
    internal class Program
    {
        public static (string, string) ToUpperAndLower(string input)//Tuple
        {
            var upper=input.ToUpper();
            var lower=input.ToLower();
            return (upper, lower); //Multiple return
        }

        static void Main(string[] args)
        {
            var res = ToUpperAndLower("Hello World");
            Console.WriteLine(res.Item1);
            Console.WriteLine(res.Item2);

            var arr = new int[] { 1,4,5,3,6,7 };

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
