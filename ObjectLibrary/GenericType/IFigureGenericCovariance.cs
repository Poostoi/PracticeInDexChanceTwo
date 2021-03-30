namespace ObjectLibrary.GenericType
{
    public interface IFigureGenericCovariance<out T>
    {
        T DoesSomethingToTheFigure(IFigure figure);
    }
}