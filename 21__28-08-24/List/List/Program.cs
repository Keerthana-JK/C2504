using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array to list conversion
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            var list = array.ToList();
            string s = "Hoooman";
            var l = s.ToArray().ToList();
            Console.WriteLine(string.Join(", ", l));
            //find common char from 2 strings
            var a = "aabcdefrtjikljd";
            var b = "abchfg";
            string common = "";

            //#1
            foreach (char c1 in a)
            {
                foreach (char c2 in b)
                {
                    if (b.Contains(c1) && !common.Contains(c1))
                    {
                        common += c1;
                        break;
                    }
                }
            }
            Console.WriteLine($"Common characters in C1 and C2: {common}");

            //#2
            var largest = a.Length > b.Length ? a : b;//ternary operator
            var smallest = a.Length < b.Length ? a : b;
            //eliminate duplicates
            var withoutDuplicates = string.Empty;
            foreach (var item in largest)
            {
                if (!withoutDuplicates.Contains(item))
                {
                    withoutDuplicates += item;
                }
            }
            foreach (var item in withoutDuplicates)
            {
                if (smallest.Contains(item))
                {
                    Console.Write($"{item} ");
                }
            }

        }
    }
}
