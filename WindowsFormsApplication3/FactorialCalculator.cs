using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class FactorialCalculator : IOneCalculator
    {
        public double Calculate(double first)
        {
            double n = 1;
            for (int i = 2; i <= first; i++)
            {
                n *= i;
            }
            return n;
        }



    }
}
