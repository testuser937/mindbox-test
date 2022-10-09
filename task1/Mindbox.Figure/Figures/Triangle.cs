using Mindbox.Figure.Validators;

namespace Mindbox.Figure.Figures;

/// <summary>
/// Triangle figure
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Tolerance to compare float-point numbers
    /// </summary>
    private const double Tolerance = 1e-9;

    public Triangle(double a, double b, double c)
    {
        FigureValidator.IsPositive(a, b, c);
        FigureValidator.IsTriangleExist(a, b, c);

        A = a;
        B = b;
        C = c;
    }

    /// <summary>
    /// Side A
    /// </summary>
    public double A { get; }

    /// <summary>
    /// Side B
    /// </summary>
    public double B { get; }

    /// <summary>
    /// Side C
    /// </summary>
    public double C { get; }

    /// <inheritdoc />
    public double CalculateArea()
    {
        // using Heron's formula to calculate area
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    /// <summary>
    /// Checks if the triangle is a right triangle (has 90 degree angle)
    /// </summary>
    /// <returns></returns>
    public bool IsRight()
    {
        return Math.Abs(A * A - (B * B + C * C)) < Tolerance ||
               Math.Abs(B * B - (A * A + C * C)) < Tolerance ||
               Math.Abs(C * C - (A * A + B * B)) < Tolerance;
    }
}