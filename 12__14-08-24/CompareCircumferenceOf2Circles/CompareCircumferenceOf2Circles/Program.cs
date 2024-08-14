//2.Circle { Radius: int }
//-double Circumference()
//- bool IsCircumferenceGt(Circle other)
//    TestCircle 

using System;

namespace CompareCircumferenceOf2Circles
{
    class Circle
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Circumference()
        {  
            return 2*3.14*radius; 
        }
        public bool IsCircumferenceGt(Circle other)
        {
            if(this.Circumference() > other.Circumference())
                return true;
            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            Circle c2 = new Circle(10);
            if (c1.IsCircumferenceGt(c2))
            {
                Console.WriteLine("C1 has larger circumference");
            }
            else if (c2.IsCircumferenceGt(c1))
            {
                Console.WriteLine("C2 has larger circumference");
            }
            else 
            {
                Console.WriteLine("Circumference of C1 and C2 are equal");
            }
        }
    }
}
