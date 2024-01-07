namespace FigureManagement.Library.Tests
{
    [TestClass]
    public class CircleTests
    {
        // “естирование вычислени€ площади круга
        [TestMethod]
        public void CalculateArea_10_314()
        {
            // Arrange
            var circle = new Circle(10);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.AreEqual(314.15926535897931, area);
        }
    }
}