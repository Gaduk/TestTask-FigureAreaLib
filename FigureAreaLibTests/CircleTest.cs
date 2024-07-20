using FigureAreaLib;

namespace FigureAreaLibTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void FindArea_R10_Return314()
        {
            // Arrange
            var circle = new Circle(10);

            // Act
            var actual = circle.FindArea();

            // Assert
            Assert.AreEqual(314, (int)actual);
        }
    }
}