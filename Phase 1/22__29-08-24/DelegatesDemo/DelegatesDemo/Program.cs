using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    delegate void DWriteLine(string str);
    internal class Program
    {
        //invokes Print("Print fn called"),
        //which in turn calls Console.WriteLine("Print fn called").
        static void Print(string a)//matches the DWriteLine delegate signature
        {
            Console.WriteLine(a);
        }

        static void PrintLetterOneByOne(string x)
        {
            foreach(var letter in x)
            {
                Console.WriteLine(letter);
            }
        }
        static void Main(string[] args)
        {
            DWriteLine wr = Console.WriteLine; //=new DWriteLine(Console.WriteLine);
            wr("Hello");
            wr("Hi");
            DWriteLine rPrint = Print;
            rPrint("Print fn called");

            DWriteLine rPrintLettersOneByOne = PrintLetterOneByOne;
            rPrintLettersOneByOne("Object Oriented Programming");

        }
    }
}
