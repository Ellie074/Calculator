using System;

namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// the calculation of the cosine
    /// </summary>
    public class CosCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
