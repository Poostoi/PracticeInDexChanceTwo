namespace ObjectLibrary.GenericType
{
    public interface IFigureGenericContravariance<in T>
    {
        void DoesSomethingToTheFigure(T figure);
    }
}