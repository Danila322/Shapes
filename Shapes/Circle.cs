using Shapes.Abstractions;

namespace Shapes;

/// <summary>
/// Круг.
/// </summary>
public sealed class Circle : IShape
{
    /// <summary>
    /// Инициализация класса <see cref="Circle"/>.
    /// </summary>
    /// <param name="radius">Радиус.</param>
    /// /// <exception cref="ArgumentOutOfRangeException">Если радиус меньше или равен нулю.</exception>
    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(radius, 0d);
        Radius = radius;
    }

    /// <summary>
    /// Радиус.
    /// </summary>
    public double Radius { get; }

    /// <inheritdoc />
    public double GetArea() => double.Pi * Radius * Radius;
}