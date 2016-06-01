namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// function division of numbers
    /// </summary>
    public class DivisionCalculator: ICalculator 
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
    }
}