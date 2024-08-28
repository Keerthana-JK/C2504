using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRING FUNCTIONS
            string Data = "   Text here  ";
            //Trim
            Console.WriteLine(Data.Trim());
            Console.WriteLine(Data.TrimStart());
            Console.WriteLine(Data.TrimEnd());

            //StartsWith, EndsWith
            Console.WriteLine(Data.StartsWith(" "));
            Console.WriteLine(Data.EndsWith("."));

            //Contains
            Console.WriteLine(Data.Contains("e"));
            Console.WriteLine(Data.Remove(0,3));

            //Replace
            Console.WriteLine(Data.Replace(" ","_"));
            //IndexOf (first occurence)
            Console.WriteLine(Data.IndexOf("e"));
            //Split (use loop to print)
            Console.WriteLine(Data.Split(' '));

            //Remove extra spaces, replace spaces with_, replace text with data
            Console.WriteLine(Data.Trim().Replace(" ", "_").Replace("text", "Data"));
            string[] arr = { "One", "Two", "Three" };
            //Concat
            Console.WriteLine(string.Concat(arr));
            //Join
            Console.WriteLine(string.Join(",",arr));

            //NUMBERS 
            var numbers = new int[] { 1, 2, 3 };
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[numbers.Length-1]);
            //Console.WriteLine(numbers.First());
            //min, max, avg, sum
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());
            //OrderBy, OrderByDescending
            //Console.WriteLine(numbers.OrderBy(m=>m));
            //Console.WriteLine(numbers.OrderByDescending(m => m));

            //Array.Sort(numbers);//modifies array by sorting
            //Array.Reverse(numbers);
            ////resize array to store 1 more element
            //Array.Resize(ref numbers, 4);

            //find max of first 5 elems, min of next 5
            var a = new int[] { 3, 6, 7, 2, 4, 7, 1, 8, 9, 6 };
            //var b = Enumerable.Range(0, 10);
            var largest = a.Take(5).Max();
            var smallest= a.Skip(5).Min();
            Console.WriteLine($"{ largest} {smallest }");
        }
    }
}