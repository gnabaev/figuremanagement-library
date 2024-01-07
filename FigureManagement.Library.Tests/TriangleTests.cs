namespace FigureManagement.Library.Tests
{
    [TestClass]
    public class TriangleTests
    {
        // Тестирование вычисления площади треугольника
        [TestMethod]
        public void CalculateArea_345_6()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        // Тестирование проверки, является ли треугольник прямоугольным
        [TestMethod]
        public void IsRight_true_true()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var isRight = triangle.IsRight();

            // Assert
            Assert.AreEqual(true, isRight);
        }

        // Тестирование проверки, является ли треугольник непрямоугольным
        [TestMethod]
        public void IsRight_false_false()
        {
            // Arrange
            var triangle = new Triangle(3, 3, 3);

            // Act
            var isRight = triangle.IsRight();

            // Assert
            Assert.AreEqual(false, isRight);
        }
    }
}
