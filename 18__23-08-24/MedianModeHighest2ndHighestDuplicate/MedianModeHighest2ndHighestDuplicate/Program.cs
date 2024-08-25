/* Median
	- middle value in a list of numbers. 
	- To find the median:
		1. Arrange the numbers in ascending order.
		2. If list has an odd number of elements, the median is the middle number.
		3. If the list has an even number of elements, the median is the average of 
			the two middle numbers.
*/

/* Mode
	- value that appears most frequently in a list of numbers. 
	- A list can have more than 1 mode if multiple values appear with the same 
		highest frequency, 
		- or no mode if all values are unique.
*/

using System;
using System.Linq;

namespace MedianModeHighest2ndHighestDuplicate
{
    internal class Program
    {
        //Median
        public static void FindMedian(int[] array)
        {
            int median = 0;
            int n=array.Length;
            if (n % 2 != 0)
                {
                    median = array[n / 2];
                }
                else
                {
                    median = array[(((n / 2) - 1) + ((n / 2) + 1)) / 2];
                }
            Console.WriteLine($"Median: {median}");
        }

        //Mode
        public static void FindMode(int[] array)
        {
            int mode = 0, maxCount=0;
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        ++count;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mode = array[i];
                }
            }

            Console.WriteLine("Mode: " + mode);
        }
        //Highest
        public static void Highest(int[] array)
        {
            
            Console.WriteLine(array.Max(x => x));
        }
        //Lowest
        public static void Lowest(int[] array)
        {

            Console.WriteLine(array.Min(x => x));
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 3, 4, 5, 5, 6, 7, 8, 8, 9 };
            FindMedian(array);
            FindMode(array);
            Highest(array);
            Lowest(array);
        }
    }
}
