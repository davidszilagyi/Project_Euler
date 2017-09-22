using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_3 : Problem
    {
        public dynamic Calculate(dynamic to)
        {
            dynamic k = 2;
            while (k * k <= to)
            {
                if(to % k == 0)
                {
                    to /= k;
                }
                else
                {
                    ++k;
                }
            }
            return to;
        }
    }
}
