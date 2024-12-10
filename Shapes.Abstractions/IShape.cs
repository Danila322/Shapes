namespace Shapes.Abstractions;

/// <summary>
/// Контракт геометрической фигуры.
/// </summary>
public interface IShape
{
    /// <summary>
    /// Метод для подсчета площади.
    /// </summary>
    /// <returns>Значение площади фигуры.</returns>
    double GetArea();
}