namespace Shapes.Tests;

public sealed class CircleTests
{
    [Fact]
    public void CircleInitShouldThrow()
    {
        var radius = 0d;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Theory]
    [MemberData(nameof(RadiusCollection))]
    public void GetAreaShouldReturnCorrectValue(double radius, double correctArea)
    {
        var circle = new Circle(radius);
        var computedArea = circle.GetArea();

        Assert.Equal(correctArea, computedArea);
    }

    public static IEnumerable<object[]> RadiusCollection { get; } =
    [
        [1, double.Pi],
        [2, double.Pi * 4],
        [3, double.Pi * 9]
    ];
}