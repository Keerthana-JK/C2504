using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        class BubbleSort
        {
            static void Main(string[] args)
            {
                int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
                Console.WriteLine("Original array:");
                PrintArray(arr);

                BubbleSortFn(arr);

                Console.WriteLine("\nSorted array:");
                PrintArray(arr);
            }

            static void BubbleSortFn(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // Swap arr[j] and arr[j + 1]
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }

            static void PrintArray(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
