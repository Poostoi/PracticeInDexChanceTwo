namespace ObjectLibrary
{
    public interface IFigure<out T>
    {
        T Square(double a, double b);
        T Perimeter(double a, double b);
    }
}