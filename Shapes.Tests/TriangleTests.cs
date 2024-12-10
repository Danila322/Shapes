namespace Shapes.Tests;

public sealed class TriangleTests
{
    [Fact]
    public void TriangleInitShouldThrow()
    {
        var first = 1d;
        var second = 2d;
        var third = 3d;

        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(first, second, third));
    }

    [Theory]
    [MemberData(nameof(SidesCollection))]
    public void GetAreaShouldReturnCorrectValue(double firstSide, double secondSide, double thirdSide, double correctArea)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        var computedArea = triangle.GetArea();

        Assert.Equal(correctArea, computedArea);
    }

    public static IEnumerable<object[]> SidesCollection { get; } =
    [
        [3, 4, 5, 6],
        [1, 1, 1, double.Sqrt(3) * 0.25]
    ];
}