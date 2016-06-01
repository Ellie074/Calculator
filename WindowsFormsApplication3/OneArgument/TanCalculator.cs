using System;

namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// the calculation of the tangent
    /// </summary>
    public class TanCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}