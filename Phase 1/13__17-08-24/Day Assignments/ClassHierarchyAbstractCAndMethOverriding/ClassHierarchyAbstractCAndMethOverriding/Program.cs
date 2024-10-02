//7.Design a Class Hierarchy with Abstract Classes and Method Overriding
//   - Task: Create an abstract class `Shape` with an abstract method `CalculateVolume()`. Derive two classes `Sphere` and `Cube` from `Shape`.
//   - Requirements:
//     - `Sphere` should have a property `Radius`. Implement `CalculateVolume()` to compute the volume of a sphere.
//     - `Cube` should have a property `SideLength`. Implement `CalculateVolume()` to compute the volume of a cube.

using System;

namespace ClassHierarchyAbstractCAndMethOverriding
{
    public abstract class Shape
    {
        public abstract string CalculateVolume();
    }

    public class Sphere : Shape
    {
        double Radius;

        public Sphere(double Radius)
        {
            this.Radius = Radius;
        }

        public override string CalculateVolume()
        {
           return $"Volume of Sphere: {(4 / 3) * 3.14 * Radius * Radius * Radius}";
        }
    }

    public class Cube : Shape
    {
        double SideLength;

        public Cube(double SideLength)
        {
            this.SideLength = SideLength;
        }

        public override string CalculateVolume()
        {
            return $"Volume of Cube: {SideLength * SideLength * SideLength}"; 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sphere = new Sphere(5);
            Console.WriteLine(sphere.CalculateVolume());

            Shape cube = new Cube(3);
            Console.WriteLine(cube.CalculateVolume());
        }
    }
}
