using System;

namespace Practice.ClassWorkIComparable
{
    public class Triangle:Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
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

        public override  double  Square()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
        public override  double  Perimeter()
        {
            return A+B+C;
        }
    }
}