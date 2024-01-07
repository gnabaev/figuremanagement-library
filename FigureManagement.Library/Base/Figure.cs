namespace FigureManagement.Library.Base
{
    public class Figure
    {
        // Площадь фигуры
        public double Area { get; set; }

        // Базовый метод вычисления площади фигуры
        public virtual double CalculateArea()
        {
            return Area;
        }
    }
}
