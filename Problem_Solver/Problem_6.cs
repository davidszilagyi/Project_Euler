﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_6 : Problem
    {
        public int Squares(int from, int to)
        {
            int squares = 0;
            int sumOfSquares = 0;
            for(int i = from; i <= to; i++)
            {
                squares += i * i;
                sumOfSquares += i;
            }
            return (sumOfSquares * sumOfSquares) - squares;
        }
    }
}
