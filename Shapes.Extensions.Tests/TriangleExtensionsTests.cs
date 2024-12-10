namespace Shapes.Extensions.Tests;

public class TriangleExtensionsTests
{
    [Fact]
    public void IsRightAngledShouldReturnFalse()
    {
        var triangle = new Triangle(1, 1, 1);
        
        var isRightAngled = triangle.IsRightAngled();
        
        Assert.False(isRightAngled);
    }
    
    [Fact]
    public void IsRightAngledShouldReturnTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        
        var isRightAngled = triangle.IsRightAngled();

        Assert.True(isRightAngled);
    }
}