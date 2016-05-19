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
        [Test]
        public void MultiplicationTest()
        {
            ICalculator calc = new MultiplicationCalculator();
            double result = calc.Calculate(2, 3);
            Assert.AreEqual(6, result, 0.00001);
        }    
    }
}
