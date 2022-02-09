using NUnit.Framework;

namespace Tests;

[TestFixture]
public class Tests
{
    private myCalc.Calculator uut;

    [SetUp]
    public void Setup()
    {
        uut = new myCalc.Calculator();
    }

    
    [TestCase(90.5,45.25,45.25)]
    [TestCase(-45.5, -90.5, 45)]
    [TestCase(-181, -90, -90)] 
    [Test]
    public void Test_Add(double a, double b, double c)
    {
        
        Assert.AreEqual(a,uut.Add(b,c));
    }

    [TestCase(50.25,45.25)]
    [TestCase(-85.5, -90.5)] 
    //[TestCase(-180, -90)]
    [Test]
    public void Test_Add_Overloaded_With_Accumulator(double expected, double argument)
    {
        uut.Add(2,3);
        Assert.AreEqual(expected,uut.Add(argument));
        uut.Clear();
        Assert.AreEqual(45.25,uut.Add(45.25));
    }

    [TestCase(10.5, 40.75, 30.25)]
    [TestCase(-300, -200, 100)]
    [TestCase(0, -90, -90)]
    [Test]
    public void Test_Subtract(double a, double b, double c)
    {
        Assert.AreEqual(a,uut.Subtract(b,c));
    }


    [TestCase(10, 2, 5)]
    [TestCase(-50, -5, 10)]
    [TestCase(50, -5, -10)]
    [Test]
    public void Test_Multiply(double a, double b, double c)
    {

        Assert.AreEqual(a,uut.Multiply(b,c));
    }



    [TestCase(9, 3, 2)]
    [TestCase(9, -3, 2)]
    [TestCase(9, 3, -2)]
    [Test]
    public void Test_Power(double a, double b, double c)
    {
        var uut = new myCalc.Calculator();

        Assert.AreEqual(9,uut.Power(3,2));
    }
}

