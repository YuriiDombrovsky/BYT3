using Tut2_s29915;

namespace Tut2_s20123.Tests;

public class Tests
{
    private readonly IShape sphere = new Sphere(5);
    private readonly IShape cylinder = new Cylinder(3, 7);
    private readonly IShape rectangle = new Rectangle(4, 8);
    private readonly IShape cube = new Cube(4);


    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }

    //todo : Complete the remaning tests here
    
    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.496).Within(0.001));
    }
    
    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }
    
    [Test]
    public void TestRectangleArea()
    {
        
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(32.0).Within(0.001));
    }
    [Test]
    public void TestRectangleVolume()
    {
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0.0));
    }
    
    [Test]
    public void TestCubeArea()
    {
        
        Assert.That(cube.CalculateArea(), Is.EqualTo(96.0));
    }
    
    [Test]
    public void TestCubeVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(64.0));
    }
    
    
}