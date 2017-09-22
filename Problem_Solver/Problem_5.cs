using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_5 : Problem
    {
        public long SmallestNumber(int from, int to)
        {
            bool match = false;
            long number = 0;
            int counter;
            while(!match)
            {
                counter = 0;
                number += to;
                for(int i = from; i <= to; i++)
                {
                    if(number % i == 0)
                    {
                        counter++;
                    }
                }
                if(counter == to)
                {
                    match = true;
                }
            }
            return number;
        }
    }
}
