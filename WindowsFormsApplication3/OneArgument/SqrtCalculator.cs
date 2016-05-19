using System;

namespace WindowsFormsApplication3.OneArgument
{
    public class SqrtCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
