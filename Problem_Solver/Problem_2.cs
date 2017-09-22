using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_2
    {
        public dynamic EvenFibonacci(dynamic to)
        {
            dynamic result = 0;
            dynamic[] fibonacci = new dynamic[] { 1, 1 };
            for(dynamic i = 0; i < to; i++)
            {
                dynamic count = fibonacci[0] + fibonacci[1];
                fibonacci[0] = fibonacci[1];
                fibonacci[1] = count;
                if (count % 2 == 0)
                {
                    result += count;
                }
                if (count >= to)
                {
                    break;
                }
            }
            return result;
        }
    }
}
