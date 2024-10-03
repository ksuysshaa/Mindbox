using Xunit;
using Geometry;
using Geometry.Figures;

namespace Geometry.Calculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Ctor_ValidRadius_CreatesCircle()
        {
            // Arrange
            const double radius = 5;
            
            // Act
            var circle = new Circle(radius);
            
            // Assert
            Assert.NotNull(circle);
        }
        
        [Fact]
        public void Ctor_InvalidRadius_ThrowsArgumentException()
        {
            // Arrange
            const double radius = -5;
            
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Circle(radius));
            Assert.Equal("Error. Radius must be greater than zero.", exception.Message);
        }
        
        [Fact]
        public void CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            const double radius = 5;
            const double expectedArea = Math.PI * radius * radius;
            var circle = new Circle(radius);
            
            // Act
            var actualArea = circle.CalculateArea();
            
            // Assert
            Assert.Equal(expectedArea, actualArea, 5);
        }
    }
}