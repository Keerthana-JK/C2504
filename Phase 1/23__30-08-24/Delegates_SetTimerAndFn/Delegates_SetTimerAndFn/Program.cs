//fn - set time 2 param (set timer, another fn)
//after that call another fn
using System;
using System.Threading;

namespace Delegates
{
    public delegate void Operation();
    internal class Program
    {
        public static void DoThis() => Console.WriteLine("Doing this after the pause");
        public static void SetTimer(int delay, Operation op)
        {
            Thread.Sleep(delay);
            op();
        }
        
        //public static void(set timer, fn2);
        static void Main(string[] args)
        {
            SetTimer(3000,DoThis);
        }
    }
}
