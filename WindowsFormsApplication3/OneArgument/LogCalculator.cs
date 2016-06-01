using System;

namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// calculation Log10
    /// </summary>
    public class LogCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}