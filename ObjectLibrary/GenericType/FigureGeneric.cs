using System;
namespace ObjectLibrary.GenericType
{
    public class FigureGeneric<T>
    {
        delegate void ConsolePrintDelegate(string message);

        private event ConsolePrintDelegate Notification;

        public T DoesSomethingToTheFigure(IFigure figure)
        {
            //Что-то происходит с фигурой

            Notification += ConsolePrint;
            Notification?.Invoke($"Ковариантность. Совершенно действие с {figure.ToString()}.");
            
            if(figure is T)
                return  (T)figure;
            throw new ArgumentException("figure is not circle");
        }
        public void DoesSomethingToTheFigure(T figure)
        {
            //Что-то происходит с фигурой

            Notification += ConsolePrint;
            Notification?.Invoke($"Контрвариантность. Совершенно действие с {figure.ToString()}.");
        }

        private void ConsolePrint(string message)
        {
            Console.WriteLine(message);
        }
    }
}