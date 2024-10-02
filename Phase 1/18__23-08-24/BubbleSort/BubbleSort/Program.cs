//1.Bubble Sort - compares adjacent elements, swaps them if they are in wrong order

using System;
using System.Security.Policy;

namespace BubbleSort
{
    internal class Program
    {
        //Bubble Sort
        public static void BubbleSort(int[] array, int n)
        {
            int temp = 0;
            for (int i = 0; i < n - 1; i++)   //outer loop : runs from 0 to n-1 (length of array)
            {
                for (int j = 0; j < n - i - 1; j++) //inner loop : runs from 0 to n-1 (compares and swaps adjacent elements, moving larger elements towards the end)
                                                    //ensures that with each pass, the next largest element is placed in its correct position
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //Print Array
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 6, 9, 2, 7, 1, 8 };
            int n = array.Length;

            BubbleSort(array, n);
            PrintArray(array);
        }
    }
}
