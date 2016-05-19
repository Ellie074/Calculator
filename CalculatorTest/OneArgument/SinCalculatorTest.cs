using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest
{
    class SinCalculatorTest
    {
        [TestCase(1, 0.8414709848)]
        [TestCase(2, 0.909297426826)]
        [TestCase(3, 0.14112000806)]
        public void SinTest(double first, double expected)
        {
            IOneCalculator calc = new SinCalculator();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }
}
