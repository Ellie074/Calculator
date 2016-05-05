using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class InvolutionCalculator : ICalculator

    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first,second);
        }
    }
}
