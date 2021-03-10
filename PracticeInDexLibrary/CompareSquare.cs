using System.Collections.Generic;
using System;

namespace Practice.ClassWorkIComparable
{
    public class CompareSquare:IComparer<Figure>
    {
        private const double Precision = 0.00001;

        public int Compare(Figure firstFigure, Figure secondFigure)
        {
            if (firstFigure != null && secondFigure != null)
            {
                double firstSquare = firstFigure.Square();
                double secondSquare = secondFigure.Square();
                if(firstSquare<secondSquare) return -1;
                else if (Math.Abs(firstSquare - secondSquare) < Precision) return 0;
                else return 1;
            }
            else
            {
                throw new ArgumentNullException("При сравнении фигур возникла ошибка: аргумент не может быть null.");
            }
        }
    }
}