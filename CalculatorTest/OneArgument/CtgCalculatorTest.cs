using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class CtgCalculatorTest
    {
        [TestCase(1, 0.642092615934)]
        [TestCase(2, -0.45765755436)]
        [TestCase(3, -7.01525255143)]
        public void CtgTest(double first, double expected)
        {
            IOneCalculator calc = new CtgCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }
}
