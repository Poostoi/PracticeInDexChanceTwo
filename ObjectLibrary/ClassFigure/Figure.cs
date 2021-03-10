using System;

namespace ObjectLibrary
{
    public abstract class Figure: IComparable
    {
        public abstract double Square();

        public abstract double Perimeter();

        private readonly double Precision = 0.00001;
        
        public int CompareTo(object other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Данной фигуры не существует.");
            }
            else
            {
                if (other is Figure)
                {
                    double othersSquare = ((Figure) other).Square();
                    double thisSquare = this.Square();
                    if (thisSquare < othersSquare) return -1;
                    else if (thisSquare - othersSquare < Precision) return 0;
                    else return 1;
                }
                else throw new ArgumentException("Сравнивать можно только с фигурой.");
            }
        }

        
    }
}