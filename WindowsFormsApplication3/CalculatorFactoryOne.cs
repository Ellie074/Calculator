using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public static class CalculatorFactoryOne
    {

        public static IOneCalculator CreateCalculatorOne (string name)
        {
            switch (name)
            {
                case "button5":
                    return new SqrtCalculator();
                case "button7":
                    return new FactorialCalculator();
                case "button8":
                    return new CosCalculator();
                case "button9":
                    return new SinCalculator();
                case "button10":
                    return new LogCalculator();
                case "button12":
                    return new TanCalculator();
                case "button13" :
                    return new CtgCalculator();
                case "button15":
                    return new PercentCalculator();
                case "button16":
                    return new ECalculate();
                default:
                    throw new Exception("error");

            }
        }
    }
}