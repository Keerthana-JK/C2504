//list of few numbers (get from user)
//fn check 
//to check fn, send a fn (is odd/is even)

using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_FnCheck
{
    //public delegate void Check(int number);
    internal class Program
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        // Function to check if a number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Function to check numbers in a list based on a passed predicate function
        public static void CheckNumbers(List<int> numbers, Predicate<int> checkFn)
        {
            foreach (int number in numbers)
            {
                if (checkFn(number))
                {
                    Console.WriteLine(number);
                }
            }
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("How many numbers do you want to enter?");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Do you want to check for odd or even numbers? (type 'odd' or 'even'):");
            string choice = Console.ReadLine().ToLower();

            Predicate<int> checkFn;

            if (choice == "odd")
            {
                checkFn = IsOdd;
            }
            else if (choice == "even")
            {
                checkFn = IsEven;
            }
            else
            {
                Console.WriteLine("Invalid choice. Defaulting to 'even'.");
                checkFn = IsEven;
            }

            Console.WriteLine("The number(s) that passed the check are:");
            CheckNumbers(list, checkFn);
        }

    }
}
