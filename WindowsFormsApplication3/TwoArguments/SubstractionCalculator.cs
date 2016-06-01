namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// subtraction function
    /// </summary>
    public class SubstractionCalculator: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}