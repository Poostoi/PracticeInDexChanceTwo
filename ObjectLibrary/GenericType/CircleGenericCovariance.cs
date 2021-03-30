namespace ObjectLibrary.GenericType
{
    public class CircleGenericCovariance<T>:FigureGeneric<T>,IFigureGenericCovariance<T> where T: Figure
    {
        
    }
}