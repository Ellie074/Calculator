using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class CosCalculatorTest
    {
        [TestCase(1, 0.540302305868)]
        [TestCase(2, -0.41614683654)]
        [TestCase(3, -0.9899924966)]
        public void CosTest(double first, double expected)
        {
            IOneCalculator calc = new CosCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }
}
