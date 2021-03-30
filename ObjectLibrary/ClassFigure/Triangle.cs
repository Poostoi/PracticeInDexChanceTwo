using System;

namespace ObjectLibrary
{
    public class Triangle : Figure
    {
        private double A { get; set; }
        private double B { get; set; }

        private double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a + b > c || b + c > a || c + a > b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new Exception("Треугольник с заданными параметрами не существует");
            }
        }

        public override double Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double Perimeter()
        {
            return A + B + C;
        }
        public override string ToString()
        {
            return "Треугольник";
        }
    }
}