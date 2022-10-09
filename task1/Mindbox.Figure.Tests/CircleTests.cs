using Mindbox.Figure.Exceptions;
using Mindbox.Figure.Figures;

namespace Mindbox.Figure.Tests;

public class CircleTests
{
    [Test]
    public void CreateValidCircleTest()
    {
        var circle = new Circle(5);
        Assert.That(circle.Radius, Is.EqualTo(5));
    }

    [Test]
    public void CreateCircleWithNegativeRadiusTest()
    {
        Assert.Throws<ValidationException>(() => { _ = new Circle(-1); });
    }

    [Test]
    public void CreateCircleWithZeroRadiusTest()
    {
        Assert.Throws<ValidationException>(() => { _ = new Circle(0); });
    }

    [Test]
    public void CalculateAreaTest()
    {
        var circle = new Circle(5);
        var expectedArea = Math.PI * circle.Radius * circle.Radius;
        Assert.That(circle.CalculateArea(), Is.EqualTo(expectedArea).Within(1e-9));
    }
}