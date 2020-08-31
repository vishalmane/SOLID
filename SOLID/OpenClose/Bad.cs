using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClose.Bad
{
    public class Rectangle
    {
        public double Height { get; set; }
        public double Wight { get; set; }
    }
    public class Circle
    {
        public double Radius { get; set; }
    }
    public class Trangle { 
    
    }
    public class AreaCalculator
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            Rectangle objRectangle;
            Circle objCircle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    var rect = obj as Rectangle;
                    area += rect.Height * rect.Wight;
                }
                else
                {
                    objCircle = (Circle)obj;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }
            return area;
        }
    }
}
