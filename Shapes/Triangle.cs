using Shapes.Abstractions;

namespace Shapes;

/// <summary>
/// Треугольник.
/// </summary>
public sealed class Triangle : IShape
{
    /// <summary>
    /// Инициализация класса <see cref="Triangle"/>.
    /// </summary>
    /// <param name="firstSide">Длина первой стороны.</param>
    /// <param name="secondSide">Длина второй стороны.</param>
    /// <param name="thirdSide">Длина третьей стороны.</param>
    /// <exception cref="ArgumentOutOfRangeException">Если одна из сторон треугольника больше суммы двух других.</exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(firstSide, secondSide + thirdSide);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(secondSide, firstSide + thirdSide);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(thirdSide, secondSide + firstSide);

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Длина первой стороны.
    /// </summary>
    public double FirstSide { get; }

    /// <summary>
    /// Длина второй стороны.
    /// </summary>
    public double SecondSide { get; }

    /// <summary>
    /// Длина третьей стороны.
    /// </summary>
    public double ThirdSide { get; }

    /// <inheritdoc />
    public double GetArea()
    {
        var perimeter = FirstSide + SecondSide + ThirdSide;
        var halfPerimeter = perimeter * 0.5;

        var squareArea = halfPerimeter * 
                         (halfPerimeter - FirstSide) *
                         (halfPerimeter - SecondSide) * 
                         (halfPerimeter - ThirdSide);

        return double.Sqrt(squareArea);
    }
}