using System;

namespace WindowsFormsApplication3.OneArgument
{
    public class SinCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
