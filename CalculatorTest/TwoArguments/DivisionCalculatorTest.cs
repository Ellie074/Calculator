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
        [Test]
        public void DivisionTest()
        {
            ICalculator calc = new DivisionCalculator();
            double result = calc.Calculate(2, 1);
            Assert.AreEqual(2, result, 0.00001);
        }    
    }

}
