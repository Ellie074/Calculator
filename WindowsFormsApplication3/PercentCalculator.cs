using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class PercentCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n;
            n = (first/100);
            return n;
        }
    }
}