using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class Service
    {
        public static long FindSumOfThirdAndFourth(long[] arr)
        {
            if (arr.Length < 4)
            { 
                Console.WriteLine("3rd or 4th element is not there");
                throw new IndexOutOfRangeException();
            }
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
                Console.WriteLine("1 trying");//Log.Debug
                if (nums.Length >= 4)
                {
                    sum = Service.FindSumOfThirdAndFourth(nums);
                }
                Console.WriteLine("1 tried");//Log.Debug
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("2 handled");//Log.Debug
                Console.WriteLine(ex.Message);//Log.Error
            }
            finally
            {
                Console.WriteLine("3 finally");//Log.Debug
            }
            Console.WriteLine("4 continued");//Log.Debug
            Console.WriteLine(sum);//Log.Info
        }
    }
}
