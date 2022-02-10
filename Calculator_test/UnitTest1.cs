using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

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
    [TestCase(-180, -90, -90)] 
    [Test]
    public void Test_Add(double a, double b, double c)
    {
        
        Assert.AreEqual(a,uut.Add(b,c));
    }

    [TestCase(50.25,45.25)]
    [TestCase(-85.5, -90.5)]
    [Test]
    public void Test_Add_Overloaded_With_Accumulator(double expected, double argument)
    {
        uut.Add(2,3); //Sætter accumulator til 5
        Assert.AreEqual(expected,uut.Add(argument)); //Tjekker om accumaltor på 5 anvendes fra start
        uut.Clear(); //Tjekker om accumulator kan cleares
        Assert.AreEqual(45.25,uut.Add(45.25)); //Tjekker om accumulator er 0 (accumulator(0) + 45.25) 
    }

    [TestCase(10.5, 40.75, 30.25)]
    [TestCase(-300, -200, 100)]
    [TestCase(0, -90, -90)]
    [Test]
    public void Test_Subtract(double a, double b, double c)
    {
        Assert.AreEqual(a,uut.Subtract(b,c));
    }

    [TestCase(5.5,20)]
    [TestCase(85.5, -60)]
    [Test]
    public void Test_Subtract_Overloaded_With_Accumulator(double expected, double argument)
    {
        uut.Subtract(30.5,5); //Sætter accumulator til 25.5
        Assert.AreEqual(expected,uut.Subtract(argument)); //Tjekker om accumaltor på 25.5 anvendes fra start
        uut.Clear(); //Tjekker om accumulator kan cleares
        Assert.AreEqual(-45.25,uut.Subtract(45.25)); //Tjekker om accumulator er 0 (accumulator(0) - 45.25) 
    }

    [TestCase(10, 2, 5)]
    [TestCase(-50, -5, 10)]
    [TestCase(50, -5, -10)]
    [Test]
    public void Test_Multiply(double a, double b, double c)
    {

        Assert.AreEqual(a,uut.Multiply(b,c));
    }

    [TestCase(22,5.5)]
    [TestCase(-34, -8.5)]
    [Test]
    public void Test_Multiply_Overloaded_With_Accumulator(double expected, double argument)
    {
        uut.Multiply(2,2); //Sætter accumulator til 4
        Assert.AreEqual(expected,uut.Multiply(argument)); //Tjekker om accumaltor på 25.5 anvendes fra start
        uut.Clear(); //Tjekker om accumulator kan cleares
        Assert.AreEqual(0,uut.Multiply(argument)); //Tjekker om accumulator er 0 (accumulator(0) - 45.25) 
    }


    [TestCase(9, 3, 2)]
    [TestCase(9, -3, 2)]
    [TestCase(0.1111111111111111, 3, -2)]
    //[TestCase(0, -2, 2.2)] //NaN -> kompleks nr
    [Test]
    public void Test_Power(double a, double b, double c)
    {
        Assert.AreEqual(a,uut.Power(b,c));
    }


    [TestCase(1, 9.5, 9.5)]
    [TestCase(-0.12,-6,50)]
    [TestCase(3.125,-12.5,-4)]
    [Test]
    public void Test_Divide(double a, double b, double c)
    {
        Assert.AreEqual(a, uut.Divide(b,c));
    }
    
    
    [TestCase(1,4)]
    [TestCase(-1,-4)]
    [Test]
    public void Test_Divide_Overloaded_With_Accumulator(double expected, double argument)
    {
        uut.Add(2,2); //Sætter accumulator til 4
        Assert.AreEqual(expected,uut.Divide(argument)); //Tjekker om accumaltor på 4 anvendes fra start
        uut.Clear(); //Tjekker om accumulator kan cleares
        Assert.AreEqual(0,uut.Divide(argument)); //Tjekker om accumulator er 0 (accumulator(0) - 45.25) 
    }
    
    
    [TestCase(1,0)]
    [Test]
    public void Test_Divide_Throws_DivideByZeroException(double a, double b)
    {
        Assert.That( () => uut.Divide(a,b), Throws.TypeOf<DivideByZeroException>());
    }
    
    [TestCase(0)]
    [Test]
    public void Test_Divide_Overloaded_Throws_DivideByZeroException(double a)
    {
        Assert.That( () => uut.Divide(a), Throws.TypeOf<DivideByZeroException>());
    }
    
}

