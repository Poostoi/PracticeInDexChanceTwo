using NUnit.Framework;
using ObjectLibrary;
using ObjectLibrary.GenericType;

namespace PracticeInDexTest
{
    [TestFixture]
    public class GenericCovarianceAndContravarianceTest
    {
        [Test]
        public void DoSomethingToTheFigureReturnTypeCheckTrue()
        {
            //Arrange
            IFigure circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5, 5);
            CircleGenericCovariance<Circle> circleGeneric = new CircleGenericCovariance<Circle>();
            RectangleGenericContravariance<Rectangle> rectangleGeneric = new RectangleGenericContravariance<Rectangle>();
            //Act
            var returnTypeCircle = circleGeneric.DoesSomethingToTheFigure(circle);
            rectangleGeneric.DoesSomethingToTheFigure(rectangle);
            //Assert
            Assert.True(returnTypeCircle is Circle);
        }
        
    }
}