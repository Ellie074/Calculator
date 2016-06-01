using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.TwoArguments;
using NUnit.Framework;

namespace CalculatorTest.TwoArguments
{
    class LogTwoCalculatorTest
    {
         [TestCase(10,10,1)]
         [TestCase(3, 5, 0.68261)]
         [TestCase(77, 12, 1.74808)]

        
        public void LogTwoTest(double first, double second, double expected)
        {
            ICalculator calc = new LogTwoCalculator();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.00001);
        }    
    }
    }

