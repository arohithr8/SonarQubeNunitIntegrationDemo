using NUnit.Framework;

namespace Demo.Tests
{
    public class CalculatorExtensionTests
    {
        [Test]
        [TestCase(-1256666,2222)]
        [TestCase(-1256666, 225525222)]
        [TestCase(0, -22222)]
        [TestCase(0, 0)]
        [TestCase(0, 5000)]
        [TestCase(222222, -5000)]
        [TestCase(222222,5555555)]
        public void AddingIntsShouldWorkAsExpected(int a, int b)
        {
            Assert.AreEqual(a + b, a.Add(b));
        }
/*
        [Test]
        [TestCase(100,1111)]
        public void SubtractingDecimalsShouldWOrk(decimal a, decimal b)
        {
            Assert.AreEqual(a.Subtract(b), a - b);
        }
*/        
    }
}
