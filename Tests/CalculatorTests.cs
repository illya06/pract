using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int v1 = 5;
            int v2 = 3;
            int expectedSum = 8;

            // Act
            int actualSum = Calc.Add(v1, v2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            int v1 = 5;
            int v2 = 3;
            int expectedDifference = 2;

            // Act
            int actualDifference = Calc.Subtract(v1, v2);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            int v1 = 5;
            int v2 = 3;
            int expectedProduct = 0;

            // Act
            int actualProduct = Calc.Multiply(v1, v2);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}
