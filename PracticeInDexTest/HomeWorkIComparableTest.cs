using System;
using NUnit.Framework;
using ObjectLibrary;


namespace PracticeInDexTest
{
    [TestFixture]
    public class HomeWorkIComparableTest
    {
        private readonly Figure[] _arrayFigure = new Figure[100];

        [SetUp]
        public void GenerateFigure()
        {
            var random = new Random();
            for (int i = 0;i<_arrayFigure.Length;i++)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        _arrayFigure[i] = new Circle(random.Next(1, 100));
                        break;
                    case 2:
                        _arrayFigure[i] = new Rectangle(random.Next(1, 100),random.Next(1, 100));
                        break;
                    case 3:
                        _arrayFigure[i] = new Triangle(random.Next(50, 99),random.Next(50, 99),random.Next(50, 99));
                        break;
                }
            }
        }
        public void SortingArrayBySquare()
        {
            Array.Sort(_arrayFigure);
        }
        public void SortingArrayByPerimeterExternal()
        {
            Array.Sort(_arrayFigure, new ComparePerimeter());
        }
        public void SortingArrayBySquareExternal()
        {
            Array.Sort(_arrayFigure, new CompareSquare());
        }

        public void ConsoleOutputSortingArrayBySquare()
        {
            SortingArrayBySquareExternal();
            foreach (var figure in _arrayFigure)
            {
                Console.WriteLine( "Площадь: {0}\n" + figure.Square());
            }
        }
        public void ConsoleOutputSortingArrayByPerimeter()
        {
            SortingArrayByPerimeterExternal();
            foreach (var figure in _arrayFigure)
            {
                Console.WriteLine( "Периметр: {1}\n" + figure.Square());
            }
        }

        [Test]
        public void SortingArrayBySquareTrue()
        {
            Array.Sort(_arrayFigure,new CompareSquare());
            
            for (int i = 1; i < _arrayFigure.Length; i++)
            {
                Assert.False(_arrayFigure[i - 1].Square() > _arrayFigure[i].Square());
            }
        }
        [Test]
        public void SortingArrayByPerimeterTrue()
        {
            Array.Sort(_arrayFigure,new ComparePerimeter());
            
            for (int i = 1; i < _arrayFigure.Length; i++)
            {
                Assert.False(_arrayFigure[i - 1].Perimeter() > _arrayFigure[i].Perimeter());
            }
        }
    }
}