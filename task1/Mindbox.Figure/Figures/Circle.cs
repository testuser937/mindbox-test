using Mindbox.Figure.Validators;

namespace Mindbox.Figure.Figures;

/// <summary>
/// Circle figure
/// </summary>
public class Circle : IFigure
{
    public Circle(double radius)
    {
        FigureValidator.IsPositive(radius);
        Radius = radius;
    }

    /// <summary>
    /// Radius of the circle
    /// </summary>
    public double Radius { get; }

    /// <inheritdoc />
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}