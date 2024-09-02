//Write a function in C# that takes a string as input and
//counts the number of characters in the string using a foreach loop
//The function should return the total count of characters
//Demonstrate the function by passing a string and displaying the character count.

using System;

namespace Looping_String_Count
{
    internal class Program
    {
        public static int CountChar(string str)
        {
            int numOfChar = 0; 
            foreach (char c in str)
            {
                numOfChar++;
            }
            return numOfChar;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string str=Console.ReadLine();
            Console.WriteLine(CountChar(str));
        }
    }
}
