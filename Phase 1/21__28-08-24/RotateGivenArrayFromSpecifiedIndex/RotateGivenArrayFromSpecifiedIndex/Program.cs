using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateGivenArrayFromSpecifiedIndex
{
    internal class Program
    {
        //#1. rotate left from location 1(print)
        public static void RotateLeftAndPrint(int[] arr,int k)
        {
            for (int i = k + 1; i < arr.Length; i++)//k-1 to end
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i <= k; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        //#2. rotate left from location 1(copy)
        public static void RotateLeftAndCopy(int[] arr, int k)
        {
            int[] arr2 = new int[100];
            int j = 0;
            for (int i = k + 1; i < arr.Length; i++)//k-1 to end
            {
                arr2[j] = arr[i];
                j++;
            }
            for (int i = 0; i <= k; i++)
            {
                arr2[j] = arr[i];
                j++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            Console.WriteLine();
        }


        //#3. rotate right from location 1(print)
        public static void RotateRightAndPrint(int[] arr, int k)
        {
            k = 6;
            for (int i = k; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i <= k - 1; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        //#4. rotate right from location 1(copy)
        public static void RotateRightAndCopy(int[] arr, int k)
        {
            k = 6;
            int[] rotated = new int[arr.Length];
            int j = 0;
            for (int i = k; i < arr.Length; i++)
            {
                rotated[j] = arr[i];
                j++;
            }
            for (int i = 0; i <= k - 1; i++)
            {
                rotated[j] = arr[i];
                j++;
            }
            for (int i = 0; i < rotated.Length; i++)
            {
                Console.Write($"{rotated[i]} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int k = 1;
            RotateLeftAndPrint(arr, k);
            RotateLeftAndCopy(arr, k);
            RotateRightAndPrint(arr, k);
            RotateRightAndCopy(arr, k);
        }
    }
}
