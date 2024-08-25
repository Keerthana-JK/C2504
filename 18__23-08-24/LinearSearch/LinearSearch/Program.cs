//Linear search - Works on unsorted arrays, with a time complexity of (O(n)).

using System;

namespace LinearSearch
{
    internal class Program
    {
        public static int LinearSearch(int[] array, int key)
        {
            int n = array.Length;
            int i = 0;
            
            for (i = 0; i < n; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            int[] array = { 20, 35, 64, 92, 47, 86, 79, 23 };
            Console.Write("Enter the element to be searched: ");
            int key = int.Parse(Console.ReadLine());
            int result = LinearSearch(array, key);
            if (result != 0)
            {
                Console.WriteLine($"{key} is located at {result}");
            }
            else
            {
                Console.WriteLine($"{key} not present in array");
            }
        }   
    }
}
