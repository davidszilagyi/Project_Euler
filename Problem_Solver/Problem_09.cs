using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_09
    {
        public long FindABC(int number)
        {
            int[] result = new int[3];
            for (int a = 0; a < number / 2; a++)
            {
                for (int b = 0; b < number / 2; b++)
                {
                    int c = number - a - b;
                    if (IsCorrect(a, b, c) && a + b + c == number && a < b && b < c)
                    {
                        result[0] = a;
                        result[1] = b;
                        result[2] = c;
                    }
                }
            }
            return result[0] * result[1] * result[2];
        }

        private bool IsCorrect(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}
