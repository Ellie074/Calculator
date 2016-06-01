namespace WindowsFormsApplication3.OneArgument
{
    /// <summary>
    /// factorial calculation
    /// </summary>
    public class FactorialCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n = 1;
            for (int i = 2; i <= first; i++)
            {
                n *= i;
            }
            return n;
        }



    }
}
