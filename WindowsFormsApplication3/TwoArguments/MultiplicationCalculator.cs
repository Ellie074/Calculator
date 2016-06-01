namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// multiplication function
    /// </summary>
    public class MultiplicationCalculator : ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        } 
    }
}