namespace Shapes.Extensions;

/// <summary>
/// Статический класс набором методов расширения для <see cref="Triangle"/>.
/// </summary>
public static class TriangleExtensions
{
    private const double EqualityPrecision = 0.00001;
    
    /// <summary>
    /// Метод проверяющий, является ли треугольник <paramref name="triangle"/> прямоугольным.
    /// </summary>
    /// <param name="triangle">Треугольник.</param>
    /// <returns>true, если треугольник <paramref name="triangle"/> прямоугольный, false - иначе.</returns>
    public static bool IsRightAngled(this Triangle triangle)
    {
        var firstSideSquare = triangle.FirstSide * triangle.FirstSide;
        var secondSideSquare = triangle.SecondSide * triangle.SecondSide;
        var thirdSideSquare = triangle.ThirdSide * triangle.ThirdSide;

        return firstSideSquare.EqualsWithPrecision(secondSideSquare + thirdSideSquare, EqualityPrecision) ||
               secondSideSquare.EqualsWithPrecision(firstSideSquare + thirdSideSquare, EqualityPrecision) ||
               thirdSideSquare.EqualsWithPrecision(firstSideSquare + secondSideSquare, EqualityPrecision);
    }
}