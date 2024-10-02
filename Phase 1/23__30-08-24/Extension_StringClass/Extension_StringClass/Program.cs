/*Extension Methods in C#:
    - allows to add new methods to existing types (here, method) without modifying original code
    - are static methods but called as if they were instance methods on extended type
    - are defined in static classes.
    - first param specifies the type you want to extend, preceded by 'this' keyword.
	- can be overloaded
	- If an extension method and an instance method have same name, instance method will take precedence
	- Use case :
		1.Adding methods to types you don't have access to (e.g., string, int, etc.).
		2. Enhancing existing types with utility functions.
*/

using System;

namespace Extension_StringClass
{
    public static class MyStringExtension
    {
        public static int NumOfKs(this string str)
        {
            int kCount = 0;
            foreach (char c in str)
            {
                if ((c == 'K') || (c == 'k'))
                {
                    kCount++;
                }
            }
            return kCount;
        }
        public static int NumOfVowels(this string str)
        {
            int vCount = 0;
            foreach (char c in str)
            {
                if ((c == 'A') || (c == 'E') || (c == 'I') || (c == 'O') || (c == 'U') || (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
                {
                    vCount++;
                }
            }

            return vCount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Keerthana Jayalal K";
            //instead of Console.WriteLine(MyStringExtension.NumOfKs(str));
            Console.WriteLine(str.NumOfKs());
            //instead of Console.WriteLine(MyStringExtension.NumOfVowels(str));
            Console.WriteLine(str.NumOfVowels());
        }
    }
}
