using System;

namespace WindowsFormsApplication3.OneArgument
{
    public class TanCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}