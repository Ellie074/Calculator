using System;

namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// involution n
    /// </summary>
    public class InvolutionCalculator : ICalculator

    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first,second);
        }
    }
}
