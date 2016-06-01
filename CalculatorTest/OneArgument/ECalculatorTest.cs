using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
    class ECalculatorTest
    {
        [TestCase(5, 13.5914091423)]
        [TestCase(3, 8.15484548538)]
        [TestCase(1, 2.71828182846)]
    
        public void ETest(double first, double expected)
        {
            IOneCalculator calc = new ECalculate();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
