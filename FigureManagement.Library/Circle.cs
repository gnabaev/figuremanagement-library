using FigureManagement.Library.Base;

namespace FigureManagement.Library
{
    public class Circle : Figure
    {
        // Радиус круга
        public double Radius { get; set; }

        // Конструктор круга по радиусу
        public Circle(int radius)
        {
            Radius = radius;
        }

        // Вычисление площади круга
        public override double CalculateArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);

            return Area;
        }
    }
}
