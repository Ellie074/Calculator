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
    class DivisionCalculatorTest
    {
        [TestCase(1,2,0.5)]
        [TestCase(2, 1, 2)]
        [TestCase(3, 2, 1.5)]
        public void DivisionTest(double first, double second, double expected)
        {
            ICalculator calc = new DivisionCalculator();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }

}
