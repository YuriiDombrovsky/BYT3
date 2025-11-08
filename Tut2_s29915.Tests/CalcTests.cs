using Tut2_s29915;

namespace Tut2_s20123.Tests;

public class CalcTests
{
    [Test]
    public void TestAddition()
    {
        var calc = new Calculator(7, 3, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(10));
    }
    
    [Test]
    public void TestSubtraction()
    {
        var calc = new Calculator(7, 3, '-');
        Assert.That(calc.Calculate(), Is.EqualTo(4));
    }
    
    [Test]
    public void TestMultiplication()
    {
        var calc = new Calculator(7, 3, '*');
        Assert.That(calc.Calculate(), Is.EqualTo(21));
    }

    [Test]
    public void TestDivision()
    {
        var calc = new Calculator(20, 4, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }
    
    [Test]
    public void TestDivisionByZero()
    {
        var calc = new Calculator(20, 0, '/');
        Assert.Throws(typeof(DivideByZeroException), () => calc.Calculate());
    }

    [Test]
    public void TestInvalidOperation()
    {
        var calc = new Calculator(7, 3, 'a');
        Assert.Throws(typeof(InvalidOperationException), () => calc.Calculate());
    }

    [Test]
    public void TestDouble()
    {
        var calc = new Calculator(10, 3, '/');
        Assert.That(calc.Calculate(), Is.EqualTo(3.333).Within(0.001));
    }
    
    [Test]
    public void TestFloatingAddition()
    {
        var calc = new Calculator(0.1, 0.2, '+');
        Assert.That(calc.Calculate(), Is.EqualTo(0.3).Within(0.001));
    }
    
}