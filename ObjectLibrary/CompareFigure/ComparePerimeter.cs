using System;
using System.Collections.Generic;

namespace ObjectLibrary
{
    public class ComparePerimeter:IComparer<Figure>
    {
        private const double Precision = 0.00001;
        public int Compare(Figure firstFigure, Figure secondFigure)
        {
            if (firstFigure != null && secondFigure != null)
            {
                var firstPerimeter = firstFigure.Perimeter();
                var secondPerimeter = secondFigure.Perimeter();
                if (firstPerimeter < secondPerimeter) return -1;
                else if (Math.Abs(firstPerimeter - secondPerimeter) < Precision) return 0;
                else return 1;
            }
            else
            {
                throw new ArgumentNullException("При сравнении фигур возникла ошибка: аргумент не может быть null.");
            }
        }
    }
}