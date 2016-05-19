namespace WindowsFormsApplication3.OneArgument
{
    public class ECalculate : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n;
            n = first*2.71828;
            return n;
        }
    }
}