using System;
using System.Runtime.ExceptionServices;

namespace RectanglesAreaComparison
{
    internal class Program
    {
        class Rectangle
        {
            public int length;  //public int Length{get; set;} //converting to property
            public int breadth; //public int Breadth{get; set;}

            public Rectangle(int length, int breadth)
            {
                this.length = length;
                this.breadth = breadth;
            }
            public override string ToString()
            {
                return $"[Length={length}, Breadth={breadth}, Area={FindArea()}]";
            }
            public int FindArea()
            {
                return length * breadth ;
            }
            public bool IsAreaGreaterThan(Rectangle other)
            {
                return FindArea() > other.FindArea() ;
            }
            public bool IsAreaEqual(Rectangle other)
            {
                return FindArea() ==other.FindArea() ;
            }
            //using 'this' keyword
            //first - calling obj
            public bool IsAreaLessThan(Rectangle second)
            {
                Rectangle first = this;
                return first.FindArea() > second.FindArea();
            }
        }
        static void Main(string[] args)
        {
            Rectangle first = new Rectangle(10,25);
            Rectangle second = new Rectangle(20,15);
            if (first.IsAreaGreaterThan(second))
            {
                Console.WriteLine($"First Land {first} is greater than Second Land{second}");
            }
            else if (first.IsAreaEqual(second))
            {
                Console.WriteLine("Equal areas");
            }
            else
            {
                Console.WriteLine($"Second Land {second} is greater than First Land{first}");
            }
        }
    }
}
