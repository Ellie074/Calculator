namespace WindowsFormsApplication3.TwoArguments
{
    /// <summary>
    /// function adds two numbers
    /// </summary>
    public class AdditionCalculator: ICalculator

{
        public double Calculate(double first, double second)
        {
            return first + second;
        }
}
}