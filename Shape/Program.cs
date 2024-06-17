using System;
namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            Shape rectangle = new Rectangle();

            Console.WriteLine($"Area of the circle: {circle.GetArea()}");
            Console.WriteLine($"Area of the rectangle: {rectangle.GetArea()}");
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public override double GetArea()
        {
            const double pi = 3.14;
            double radius = 4;

            double result = pi * radius * radius;
            return result;
        }
    }

    public class Rectangle : Shape
    {
        public override double GetArea()
        {
            double length = 5;
            double width = 3;

            double result = length * width;
            return result;
        }
    }
}