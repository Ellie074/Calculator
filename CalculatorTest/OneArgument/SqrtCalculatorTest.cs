using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class SqrtCalculatorTest
    {
        [TestCase(12, 3.46410161514)]
        [TestCase(55, 7.4161984871)]
        [TestCase(16, 4)]

        public void SqrtTest(double first, double expected)
        {
            IOneCalculator calc = new SqrtCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
