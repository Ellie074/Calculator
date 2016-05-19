namespace WindowsFormsApplication3.OneArgument
{
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