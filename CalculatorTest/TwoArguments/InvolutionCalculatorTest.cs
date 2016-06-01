using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArguments
{
    class InvolutionCalculatorTest
    {

        [TestCase (3,2,9)]
        [TestCase(7, 5, 16807)]
        [TestCase(5, 3, 125)]
        
        public void InvolutionTest(double first, double second, double expected)
        {
            ICalculator calc = new InvolutionCalculator();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }
}
