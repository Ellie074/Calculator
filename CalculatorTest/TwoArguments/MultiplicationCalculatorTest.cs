using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.OneArgument;
using WindowsFormsApplication3.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArguments
{
    class MultiplicationCalculatorTest
    {
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 2, 6)]
        public void MultiplicationTest(double first, double second, double expected)
        {
            ICalculator calc = new MultiplicationCalculator();
            double result = calc.Calculate( first, second);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }
}
