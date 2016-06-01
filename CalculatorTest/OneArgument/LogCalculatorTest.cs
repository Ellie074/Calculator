using System;
using WindowsFormsApplication3.OneArgument;
using NUnit.Framework;

namespace CalculatorTest.OneArgument
{
        class LogCalculatorTest
        {
            [TestCase(1, 0)]
            [TestCase(5, 0.69897000433)]
            [TestCase(17, 1.23044892138)]

            public void LogTest(double first, double expected)
            {
                IOneCalculator calc = new LogCalculator();
                double result = calc.Calculate(first);
                Assert.AreEqual(expected, result, 0.00001);
            }
        }
}
