//fn convert case (string)
//res = swapped case
//(string was converted to Uppercase)


using System;

namespace StringSwapCase
{
    internal class Program
    {
        enum ConversionResult
        {
            Upper,
            Lower
        }
        static ConversionResult StringSwapCase(string Str, out string result)
        {
            if (char.IsLower(Str[0]))
            {
                result = Str.ToUpper();
                return ConversionResult.Upper;
            }
            else
            {
                result = Str.ToLower();
                return ConversionResult.Lower;
                
            }
        }


        static void Main(string[] args)
        {
            //Console.WriteLine(StringSwapCase("Samir", out string result));
            //Console.WriteLine(StringSwapCase("haritha", out string result));
            switch(StringSwapCase("Samir", out string result))
            {
                case ConversionResult.Lower:
                    Console.WriteLine($"Result after converting to lowercase: {result}");
                    break;
                case ConversionResult.Upper:
                    Console.WriteLine($"Result after converting to uppercase: {result}");
                    break;
            }
        }
    }
}
