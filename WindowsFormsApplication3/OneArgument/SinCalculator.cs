using System;

namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// sine calculation
    /// </summary>
    public class SinCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
