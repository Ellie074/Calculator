using System;

namespace WindowsFormsApplication3.TwoArguments
{
    public class LogTwoCalculator : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}