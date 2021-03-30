namespace ObjectLibrary.GenericType
{
    public class RectangleGenericContravariance<T>: FigureGeneric<T>,IFigureGenericContravariance<T> where T:Figure
    {
        
    }
}