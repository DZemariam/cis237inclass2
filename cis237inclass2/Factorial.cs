using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public int CalculateFactorial (int number)
        {
            //Base Case
            if (number == 1)
            {
                return number;
            }
            //Not base case, recursive call our self.
            return number * CalculateFactorial(number - 1);
        }
    }
}
