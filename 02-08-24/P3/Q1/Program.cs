using System;


namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //continue
            for (int i = 1; i <= 10; i++)
            {
            if (i % 2 != 0)
                continue;
            Console.WriteLine(i);

            }
        }
    }
}
