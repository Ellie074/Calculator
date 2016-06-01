using System;

namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// calculation of the number of a root
    /// </summary>
    public class SqrtCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
