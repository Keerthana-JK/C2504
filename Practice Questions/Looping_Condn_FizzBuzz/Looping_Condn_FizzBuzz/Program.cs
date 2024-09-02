//To print natural numbers from 1 to 100

//if divisible by 3, Print msg Fizz
//if divisible by 5, Print msg Buzz
//if divisible by both 3 and 5, Print msg FizzBuzz


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_Condn_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            { 
                if((i%3==0)&&(i%5==0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if(i%5==0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}
