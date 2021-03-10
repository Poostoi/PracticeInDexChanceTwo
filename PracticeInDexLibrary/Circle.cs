using System;

namespace Practice.ClassWorkIComparable
{
    public class Circle:Figure
    {
        public double R { get; set; }

        public Circle(double r)
        {
            
            if (r>0)
            {
                R = r;
            }
            else
            {
                throw new Exception("Круг с заданными параметрами не существует");
            }
        }

        public override  double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public override  double Perimeter()
        {
            return 2*Math.PI * R;
        }
    }
}