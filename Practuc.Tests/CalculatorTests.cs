using Practic;

namespace Practuc.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc = new Calculator();
        [Test]
        [TestCase(3, 5, 8)]
        [TestCase(10, 100, 110)]
        [TestCase(-4, 4, 0)]
        public void AdditionalMustReturnCorrectValue(int a, int b, int expected)
        {
            var actual = calc.Additional(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-1, -4, 3)]
        [TestCase(-1, 4, -5)]
        [TestCase(3, 5, -2)]
        [TestCase(100, 5, 95)]
        [TestCase(100, -5, 105)]
        public void SubtractionMustReturnCorrectValue(int a, int b, int expected)
        {
            var actual = calc.Subtraction(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(-2, -3, 6)]
        [TestCase(100, 100, 10000)]
        public void MiltiplicationMustReturnCorrectValue(int a, int b, int expected)
        {
            var actual = calc.Miltiplication(a, b);
            Assert.That (actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 234, 0)]
        [TestCase(6, 3, 2)]
        [TestCase(9, 2, 4)]
        [TestCase(9, 3, 3)]
        public void DivisionMustReturnCorrectValue(int a, int b, int expected)
        {
            var actual = calc.Division(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(3, 0)]
        public void DiveisionReturnException(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => calc.Division(a, b));
        }
    }
}