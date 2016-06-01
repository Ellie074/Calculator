using System;

namespace WindowsFormsApplication3.OneArgument
{
   /// <summary>
   /// the calculation of the cotangent
   /// </summary>
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