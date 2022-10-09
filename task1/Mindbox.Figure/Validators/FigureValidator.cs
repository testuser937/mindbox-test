using Mindbox.Figure.Exceptions;

namespace Mindbox.Figure.Validators;

/// <summary>
/// Provides validation functions
/// </summary>
public static class FigureValidator
{
    /// <summary>
    /// Checks if all elements in array are positive
    /// </summary>
    /// <param name="nums">Array of nums to check</param>
    /// <exception cref="ValidationException">Throws ValidationException if any number not positive</exception>
    public static void IsPositive(params double[] nums)
    {
        if (nums.Any(n => n <= 0))
        {
            throw new ValidationException("Number must be positive");
        }
    }

    /// <summary>
    /// Checks if a triangle with the given sides exists
    /// </summary>
    /// <param name="a">Side A</param>
    /// <param name="b">Side B</param>
    /// <param name="c">Side C</param>
    /// <exception cref="ValidationException">Throws ValidationException if triangle with given sides not exists</exception>
    public static void IsTriangleExist(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
        {
            throw new ValidationException("Sum of the two sides of triangle must be greater than the third side");
        }
    }
}