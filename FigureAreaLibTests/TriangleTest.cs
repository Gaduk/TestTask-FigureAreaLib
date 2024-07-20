using FigureAreaLib;

namespace FigureAreaLibTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void FindArea_A3B4C5_Return6()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var actual = triangle.FindArea();

            // Assert
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void isRightAngled_A3B4C5_True()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            var actual = triangle.isRightAngled();

            // Assert
            Assert.AreEqual(true, actual);
        }
    }
}