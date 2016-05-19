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
    class AdditionCalculatorTest
    {
        [TestCase(1, 2, 3)]
        [TestCase(3, 1, 4)]
        [TestCase(3, 2, 5)]
        public void AdditionTest(double first, double second, double expected)
        {
            ICalculator calc = new AdditionCalculator();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }

}
