using Mindbox.Figure.Exceptions;
using Mindbox.Figure.Figures;

namespace Mindbox.Figure.Tests;

public class TriangleTests
{
    [Test]
    public void CreateValidCircleTest()
    {
        var a = 3;
        var b = 4;
        var c = 5;
        var triangle = new Triangle(a, b, c);
        Assert.Multiple(() =>
        {
            Assert.That(triangle.A, Is.EqualTo(a));
            Assert.That(triangle.B, Is.EqualTo(b));
            Assert.That(triangle.C, Is.EqualTo(c));
        });
    }

    [Test]
    public void CreateTriangleWithNegativeSideTest()
    {
        Assert.Throws<ValidationException>(() => { _ = new Triangle(1, 2, -1); });
    }

    [Test]
    public void CreateTriangleWithZeroSideTest()
    {
        Assert.Throws<ValidationException>(() => { _ = new Triangle(0, 2, 3); });
    }

    [Test]
    public void CreateNotPossibleTriangle()
    {
        Assert.Throws<ValidationException>(() => { _ = new Triangle(1, 2, 500); });
    }

    [Test]
    public void CheckTriangleIsRightTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsRight(), Is.True);
    }

    [Test]
    public void CheckTriangleIsNotRightTest()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.That(triangle.IsRight(), Is.False);
    }

    [Test]
    public void CalculateAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6d;
        Assert.That(triangle.CalculateArea(), Is.EqualTo(expectedArea).Within(1e-9));
    }
}