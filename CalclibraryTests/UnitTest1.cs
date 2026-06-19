using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new SimpleCalculator();
        }

        [Test]
        public void Addition_Test()
        {
            double result = calc.Addition(10, 20);
            Assert.That(result, Is.EqualTo(30));
        }
    }
}