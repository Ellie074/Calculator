using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class PercentCalculatorTest
    {
        [TestCase(10, 0.1)]
        [TestCase(140, 1.4)]
        [TestCase(52.5, 0.525)]
        

        public void PercentTest(double first, double expected)
        {
            IOneCalculator calc = new PercentCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
