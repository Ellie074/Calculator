using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class CosCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
