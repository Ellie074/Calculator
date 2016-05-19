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
        [Test]
        public void AdditionTest()
        {
            ICalculator calc = new AdditionCalculator();
            double result = calc.Calculate(2, 5);
            Assert.AreEqual(7, result, 0.00001);
        }    
    }

}
