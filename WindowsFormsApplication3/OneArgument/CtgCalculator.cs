using System;

namespace WindowsFormsApplication3.OneArgument
{
    public class CtgCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n;
            n = 1/Math.Tan(first);
            return n;
        }
    }
}