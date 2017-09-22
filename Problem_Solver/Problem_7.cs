using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_7
    {
        public long WhatIsThePrime(int index)
        {
            int numPrimes = 1;
            int num = 1;

            while (numPrimes < index)
            {
                num = num + 2;
                if (IsPrime(num))
                {
                    numPrimes++;
                }
            }
            return num;
        }

        private bool IsPrime(int num)
        {
            if (num <= 1 || num % 2 == 0)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }

            int counter = 3;

            while ((counter * counter) <= num)
            {
                if (num % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2;
                }
            }

            return true;
        }
    }
}
