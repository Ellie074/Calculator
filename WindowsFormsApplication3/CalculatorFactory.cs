using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case"button1":
                    return new AdditionCalculator();
                case "button2":
                    return new SubstractionCalculator();
                case "button3":
                    return new MultiplicationCalculator();
                case "button4":
                    return new DivisionCalculator();
                default:
                    throw new Exception("error");




            }
        }
    }
}
