using System;

namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// factory for Two argument calculaor
    /// </summary>
    public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case"button1":
                    return new AdditionCalculator();
                case "button2":
                    return new SubstractionCalculator();
                case "button3":
                    return new MultiplicationCalculator();
                case "button4":
                    return new DivisionCalculator();
                case "button6" :
                    return new InvolutionCalculator();
                case "button11":
                    return new LogTwoCalculator();
                default:
                    throw new Exception("error");




            }
        }
    }
}
