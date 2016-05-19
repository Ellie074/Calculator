using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    public class CosCalculatorTest
    {
        [Test]
        public void CosTest()
        {
            IOneCalculator calc = new CosCalculator();
            double result = calc.Calculate(2);
            Assert.AreEqual(-0.41614683654, result, 0.00001);
        }    
    }
}
