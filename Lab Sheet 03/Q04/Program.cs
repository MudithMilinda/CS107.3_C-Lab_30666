using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    public class Shape
    {
        public string shapeType;
        public double area;

        public Shape(string shapeType, double area)
        {
            this.shapeType = shapeType;
            this.area = area;
        }

        public virtual void CalculateArea(double val1, double val2)
        {
            Console.WriteLine("Area Calculating...");
        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {shapeType}");
            Console.WriteLine($"Area: {area}");
        }
    }

    public class Rectangle : Shape
    {
        public double length;
        public double width;

        public Rectangle()
        {
            shapeType = "Rectangle";
        }

        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea(length, width);
        }

        public override void CalculateArea(double length, double width)
        {
            area = length * width;
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            shapeType = "Circle";
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
            CalculateArea(radius);
        }

        public override void CalculateArea(double radius)
        {
            area = Math.PI * radius * radius;
        }

        public override void DisplayShapeInfo()
        {
            base.DisplayShapeInfo();
            Console.WriteLine($"Radius: {radius}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetDimensions(5, 3);

            Console.WriteLine("Rectangle Information:");
            rectangle.DisplayShapeInfo();

            Circle circle = new Circle();
            circle.SetRadius(4);

            Console.WriteLine("\nCircle Information:");
            circle.DisplayShapeInfo();

            Console.ReadLine();
        }
    }
}
