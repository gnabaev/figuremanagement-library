using FigureManagement.Library.Base;

namespace FigureManagement.Library
{
    public class Triangle : Figure
    {
        // Длина первой стороны
        public double FirstSide { get; set; }

        // Длина второй стороны
        public double SecondSide { get; set; }

        // Длина третьей стороны
        public double ThirdSide { get; set; }

        // Конструктор треугольника по 3 сторонам
        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        // Вычисление площади треугольника
        public override double CalculateArea()
        {
            // Вычисление полупериметра треугольника
            var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            Area = Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));

            return Area;
        }

        // Проверка, является ли треугольник прямоугольным
        public bool IsRight()
        {
            // Вычисление квадратов сторон треугольника
            var firstSideSquare = Math.Pow(FirstSide, 2);
            var secondSideSquare = Math.Pow(SecondSide, 2);
            var thirdSideSquare = Math.Pow(ThirdSide, 2);

            // Проверка через равенство квадратов сторон по теореме Пифагора
            if (firstSideSquare == secondSideSquare + thirdSideSquare || secondSideSquare == firstSideSquare + thirdSideSquare || thirdSideSquare == firstSideSquare + secondSideSquare)
            {
                return true;
            }

            return false;
        }
    }
}
