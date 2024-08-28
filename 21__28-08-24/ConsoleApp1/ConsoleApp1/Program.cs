using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int FindCharInArray(char[] letters, char target)
        {
            int index = 0;
            foreach (var ch in letters)
            {
                if(ch==target) return index;
                index++;
            }
            return -1;
        }

            static void Main(string[] args)
        {
            // Count of frequency of characters in a string (without using dictionary)
            Console.Write("Enter the string: ");
            string sentence = Console.ReadLine();
            char[] letters = new char[100];
            int letterCount = 0;
            int[] counts = new int[100];
            foreach (char ch in sentence)
            {
                int pos = FindCharInArray(letters, ch);
                //if existing char is encountered
                if (pos != -1)
                {
                    counts[pos]++;
                    continue;
                }
                //if new char is encountered
                letters[letterCount] = ch;
                counts[letterCount] = 1;
                letterCount++;
            }
            for (int i = 0; i < letterCount; i++)
            {
                Console.WriteLine($"{letters[i]} occured {counts[i]} times");
            }

            //###Simplest way (using GroupBy (LINQ))
            //var groups = sentence.GroupBy(m => m);
            //foreach (var item in groups)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Count()}");
            //}
        }
    }
}
