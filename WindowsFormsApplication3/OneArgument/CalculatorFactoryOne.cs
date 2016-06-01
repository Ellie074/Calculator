using System;

namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// factory for One argument calculaor
    /// </summary>
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