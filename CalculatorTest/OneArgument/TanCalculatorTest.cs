using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class TanCalculatorTest
    {
        [TestCase(11, -225.950846454)]
        [TestCase(90, -1.99520041221)]
        [TestCase(88, 0.03542050133)]

        public void TanTest(double first, double expected)
        {
            IOneCalculator calc = new TanCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
