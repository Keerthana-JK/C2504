using System;

namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] sortedArray = { 10, 10, 20, 30, 40, 40, 50, 50, 60 };
            int[] distinctArray = new int[100];
            int distinctSize = 0;

            //#1

            for (int i = 0; i <= sortedArray.Length - 2; i++)//0 to second-last element
            {
                if (sortedArray[i] == sortedArray[i + 1])//if current element == next element, continue
                {
                    continue;
                }
                distinctArray[distinctSize] = sortedArray[i];//if not equal, add that element to distinctArray
                distinctSize++;     //increment size of distinctArray as the element is added
            }
            //Edge condition
            distinctArray[distinctSize] = sortedArray[sortedArray.Length - 1];
            distinctSize++;

            for (int i = 0; i < distinctSize; i++)
            {
                Console.Write($"{distinctArray[i]} ");
            }


            //#2
            //distinctArray[distinctSize] = sortedArray[0];
            //distinctSize++;
            //starts from the second elements 
            //checks if second element is same as first element
            //for (int i = 1; i < sortedArray.Length; i++)
            //{
            //    //checks for every element if it is the same as the previous element
            //    //if same, then continue
            //    if (sortedArray[i-1] == sortedArray[i])
            //    {
            //        continue;
            //    }

            //    distinctArray[distinctSize] = sortedArray[i];
            //    distinctSize++;
            //}
            ////Prints array after removing duplicate
            //for (int i = 0; i < distinctSize; i++)
            //{
            //    Console.Write($"{distinctArray[i]} ");
            //}
        }
    }
}
