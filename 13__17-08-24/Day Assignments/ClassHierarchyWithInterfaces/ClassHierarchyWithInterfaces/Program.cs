//2.Design a Class Hierarchy with Interfaces
//   - Task: Create an interface `IDrawable` with a method `Draw()`. Create a base class `Graphic` that implements `IDrawable` and has a method `Resize()`.
//          Derive two classes `Line` and `Polygon` from `Graphic`.
//   - Requirements:
//     - `Line` should have properties `StartPoint` and `EndPoint`. Implement the `Draw()` method to draw a line.
//     - `Polygon` should have a property `Vertices` (a list of points). Implement the `Draw()` method to draw a polygon.
//     - Implement the `Resize()` method in both derived classes to adjust their dimensions.

using System;
using System.Collections.Generic;

namespace ClassHierarchyWithInterfaces
{
    internal class Program
    {
        interface IDrawable
        {
            void Draw();
        }
        public abstract class Graphic : IDrawable
        {
            public void Resize(double r)
            {
                r = 0.1;
            }
            public abstract void Draw();    
        }
        public class Line : Graphic
        {
            Point StartPoint;
            Point EndPoint;

            public Line(Point startPoint, Point endPoint)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }
            public override void Draw()
            {
                Console.WriteLine($"Drawing line from {StartPoint} to {EndPoint}");
            }
        }

        public class Polygon : Graphic
        {
            List<Point> vertices;

            public Polygon(List<Point> vertices)
            {
                this.vertices = vertices;
            }

            public override void Draw()
            {
                Console.WriteLine("Drawing polygon with vertices:");
                foreach (var vertex in vertices)
                {
                    Console.WriteLine(vertex);
                }
            }

        }
        public class Point
        {
            int X, Y;
            public Point(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }
        static void Main(string[] args)
        {
            IDrawable line = new Line(new Point(0, 0), new Point(10, 10));
            line.Draw(); // Draws a line from (0,0) to (10,10)

            Graphic polygon = new Polygon(new List<Point> { new Point(0, 0), new Point(10, 0), new Point(10, 10), new Point(0, 10) });
            polygon.Resize(2); // Resize polygon
            polygon.Draw(); // Draws the resized polygon
        }
    }
}
