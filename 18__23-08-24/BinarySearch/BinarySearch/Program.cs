//Binary search
// -Requires a sorted array, with a time complexity of (O(\log n)).
//	- repeatedly divides the search interval in half 
//		until the value is found or the interval is empty.

using System;

namespace Binary
{
    internal class Program
    {
        public static int BinarySearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length-1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid]==key)
                {
                    Console.WriteLine(mid);
                    return mid;
                }
                if (array[mid] < key)
                {
                    left = mid + 1;//ignores left half
                }
                else
                {
                    right = mid - 1;//ignores right half
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = { 20, 23, 35, 47, 79, 86 };//Sorted array
            Console.Write("Enter the element to be searched: ");
            int key = int.Parse(Console.ReadLine());
            int result = BinarySearch(array, key);
            if (result != -1)
            {
                Console.WriteLine($"{key} is located at {result}");
            }
            else
            {
                Console.WriteLine($"{key} is not present in array");
            }
        }
    }
}
