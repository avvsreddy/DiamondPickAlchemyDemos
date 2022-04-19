using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            // should find sum for only non zero positive numbers only
            if (a <= 0 || b <= 0)
                throw new InvalidInputException("Input is not valid");
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a- b;
        }

    }
}
