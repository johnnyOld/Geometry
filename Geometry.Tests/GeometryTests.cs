namespace Geometry.Tests;

[TestFixture]
public class GeometryTests
{
    [Test]
    public void CircleArea_Radius3_Returns28point27()
    {
        double radius = 3;
        double expected = 28.27;

        double result = Geometry.CircleArea(radius);

        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    [Test]
    public void TriangleArea_3_4_5_Returns6()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double expected = 6;

        double result = Geometry.TriangleArea(a, b, c);

        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    [Test]
    public void IsRightTriangle_3_4_5_ReturnsTrue()
    {
        double a = 3;
        double b = 4;
        double c = 5;

        bool result = Geometry.IsRightTriangle(a, b, c);

        Assert.IsTrue(result);
    }

    [Test]
    public void IsRightTriangle_5_12_13_ReturnsTrue()
    {
        double a = 5;
        double b = 12;
        double c = 13;

        bool result = Geometry.IsRightTriangle(a, b, c);

        Assert.That(result, Is.True);
    }

    [Test]
    public void Area_Circle_Radius3_Returns28point27()
    {
        string type = "circle";
        double radius = 3;
        double expected = 28.27;

        double result = Geometry.Area(type, radius);

        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }

    [Test]
    public void Area_Triangle_3_4_5_Returns6()
    {
        string type = "triangle";
        double a = 3;
        double b = 4;
        double c = 5;
        double expected = 6;

        double result = Geometry.Area(type, a, b, c);

        Assert.That(result, Is.EqualTo(expected).Within(0.01));
    }
}


