using System;

namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// the function of the logarithm to the base x n
    /// </summary>
    public class LogTwoCalculator : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}