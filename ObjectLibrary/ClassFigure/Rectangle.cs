using System;

namespace ObjectLibrary
{
    public class Rectangle:Figure
    {
        private double Width { get; set; }
        private double Length { get; set;}
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
        public override string ToString()
        {
            return "Прямоугольник";
        }
    }
}