using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClose.Good
{
    public abstract class Shape
    {
       
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
    public class Trangle : Shape
    {
        public double Height { get; set; }
        public double b { get; set; }

        public override double Area()
        {
            return (b * Height) / 2;
        }
    }
}
