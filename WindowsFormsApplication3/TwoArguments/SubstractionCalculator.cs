namespace WindowsFormsApplication3.TwoArguments
{
    public class SubstractionCalculator: ICalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}