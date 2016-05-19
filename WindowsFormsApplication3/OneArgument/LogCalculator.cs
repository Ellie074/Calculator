using System;

namespace WindowsFormsApplication3.OneArgument
{
    public class LogCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log(first);
        }
    }
}