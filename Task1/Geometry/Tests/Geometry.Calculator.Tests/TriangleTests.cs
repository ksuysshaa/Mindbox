// Task1/Geometry/Tests/Geometry.Calculator.Tests/TriangleTests.cs
using Xunit;
using Geometry;
using Geometry.Figures;

namespace Geometry.Calculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Ctor_ValidSides_CreatesTriangle()
        {
            // Arrange
            const double firstSide = 3;
            const double secondSide = 4;
            const double thirdSide = 5;
            
            // Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            
            // Assert
            Assert.NotNull(triangle);
        }
        
        [Theory]
        [InlineData(-3, 4, 5, "Error. Side must be greater than zero.")]
        [InlineData(3, -4, 5, "Error. Side must be greater than zero.")]
        [InlineData(3, 4, -5, "Error. Side must be greater than zero.")]
        [InlineData(10, 4, 3, "Error. Triangle with such sides does not exist.")]
        [InlineData(3, 10, 4, "Error. Triangle with such sides does not exist.")]
        [InlineData(3, 4, 10, "Error. Triangle with such sides does not exist.")]
        public void Ctor_InvalidSides_ThrowsArgumentException(double firstSide, double secondSide, double thirdSide, string expectedMessage)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
            Assert.Equal(expectedMessage, exception.Message);
        }
        
        [Fact]
        public void CalculateArea_ValidSides_ReturnsArea()
        {
            // Arrange
            const double firstSide = 3;
            const double secondSide = 4;
            const double thirdSide = 5;
            const double expectedArea = 6;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            
            // Act
            var actualArea = triangle.CalculateArea();
            
            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            // Arrange
            const double firstSide = 3;
            const double secondSide = 4;
            const double thirdSide = 5;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Act
            var actualResult = triangle.IsRightAngled();

            // Assert
            Assert.True(actualResult);
        }
        
        [Fact]
        public void IsRightAngled_NonRightAngledTriangle_ReturnsFalse()
        {
            // Arrange
            const double firstSide = 4;
            const double secondSide = 4;
            const double thirdSide = 5;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Act
            var actualResult = triangle.IsRightAngled();

            // Assert
            Assert.False(actualResult);
        }
    }
}