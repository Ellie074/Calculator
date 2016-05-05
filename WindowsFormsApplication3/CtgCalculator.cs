using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class CtgCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n;
            n = 1/Math.Tan(first);
            return n;
        }
    }
}