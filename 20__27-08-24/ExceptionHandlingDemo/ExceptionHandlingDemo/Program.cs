﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Service
    {
        public static long FindSumOfThirdAndFourth(long[] arr)
        {
            return arr[2] + arr[3];
        }
    }
    internal class Programs
    {

        static void Main(string[] args)
        {
            //long[] nums = { 10, 20, 30, 40, 50, 60, 70, 80, 90 }; //No Err
            long[] nums = { 10, 20, 30 }; //Err
            long sum = 0;

            try
            {
                sum = Service.FindSumOfThirdAndFourth(nums);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);//Log.Error
            }

            Console.WriteLine(sum);//Log.Info

        }
    }
}
