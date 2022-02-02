using NUnit.Framework;

namespace Calculator_test
{
    [TestFixture]
    public class Tests : ITests
    {
        private myCalc.Calculator uut;
        [SetUp]
        public void Setup()
        {
            //bliver kaldt før hver eneste test 

            uut = new myCalc.Calculator();
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var uut = new myCalc.Calculator();

            //Act
            //lav evt metodekald her sådan at man kan tjekke en property/attribut i assert 

            //Assert
            Assert.That(uut.Add(2.5, 2.5), Is.EqualTo(5));
        }

        [TestCase(5,2,3)]
        [Test]
        public void Test2(int a, int b, int c)
        {
            Assert.AreEqual(a,uut.Add(b,c));
        }


    }
}