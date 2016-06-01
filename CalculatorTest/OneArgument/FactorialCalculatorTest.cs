using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class FactorialCalculatorTest
    {
        [TestCase(5, 120)]
        [TestCase(3,6)]
        [TestCase(10, 3628800)]
        
        public void FactorialTest(double first, double expected)
        {
            IOneCalculator calc = new FactorialCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
