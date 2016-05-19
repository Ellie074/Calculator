using System;

namespace WindowsFormsApplication3.OneArgument
{
    public class CosCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
