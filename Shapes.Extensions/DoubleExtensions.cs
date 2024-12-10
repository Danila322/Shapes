namespace Shapes.Extensions;

internal static class DoubleExtensions
{
    public static bool EqualsWithPrecision(this double value, double other, double precision) => 
        double.Abs(value - other) <= precision;
}