namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// translating numbers into percentages
    /// </summary>
    public class PercentCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n;
            n = (first/100);
            return n;
        }
    }
}