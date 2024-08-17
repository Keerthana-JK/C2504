using System;
using System.Runtime.InteropServices.ComTypes;

namespace Enums
{
    internal class Program
    {
        enum Days
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum Conversions
        {
            Upper, Lower, Trim
        }
        static void Convert(string text, Conversions action)
        {
            if (action == Conversions.Upper)
                Console.WriteLine(text.ToUpper());
            else if (action == Conversions.Lower)
                Console.WriteLine(text.ToLower());
            else if (action == Conversions.Trim)
                Console.WriteLine(text.Trim());

            //switch(action)
            //{
            //    case Conversions.Upper:
            //        Console.WriteLine(text.ToUpper());
            //        break;
            //    case Conversions.Lower: 
            //        Console.WriteLine(text.ToLower());  
            //        break;
            //     case Conversions.Trim:
            //        Console.WriteLine(text.Trim());
            //        break;
            //}
        }
        static void Main()
        {

            //Days
            Days today = Days.Monday;
            switch (today)
            {
                case Days.Monday:
                    Console.WriteLine("It's Monday, back to work!");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("It's Tuesday, let's keep the momentum going!");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("It's Wednesday, halfway through the week!");
                    break;
                case Days.Thursday:
                    Console.WriteLine("It's Thursday, the weekend is near!");
                    break;
                case Days.Friday:
                    Console.WriteLine("It's Friday, the weekend starts tomorrow!");
                    break;
                case Days.Saturday:
                    Console.WriteLine("It's Saturday, time to relax!");
                    break;
                case Days.Sunday:
                    Console.WriteLine("It's Sunday, rest up for the week ahead.");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }
            Convert("   Hello  ", Conversions.Upper);
            Convert("  Hello   ", Conversions.Lower);
            Convert("   Hello  ", Conversions.Trim);
        }
    }
}
