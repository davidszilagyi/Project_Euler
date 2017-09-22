using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_10
    {
        public long SumOfPrimes(long max)
        {
            long result = 2;
            for (int i = 3; i <= max; i += 2)
            {
                if (IsPrime(i))
                {
                    result += i;
                }
            }
            return result;
        }

        private bool IsPrime(long number)
        {
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
