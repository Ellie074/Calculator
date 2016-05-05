using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class ECalculate : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n;
            n = first*2.71828;
            return n;
        }
    }
}