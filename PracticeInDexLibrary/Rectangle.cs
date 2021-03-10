using System;

namespace Practice.ClassWorkIComparable
{
    public class Rectangle:Figure
    {
        public double Width { get; private set; }
        public double Length { get; private set;}
        public Rectangle(double width, double length) 
        {
            if (width>0&&length>0)
            {
                Width = width;
                Length = length;
            }
            else
            {
                throw new Exception("Прямоугольник с заданными параметрами не существует");
            }
            
        }

        public override  double  Square()
        {
            return Length * Width;
        }
        public override  double  Perimeter()
        {
            return 2*(Length + Width);
        }
    }
}