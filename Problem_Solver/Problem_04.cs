using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler.Problem_Solver
{
    class Problem_04
    {
        public long PalindromeNumber(int from, int to)
        {
            long result = 0;
            for(int i = from; i >= to; i--)
            {
                for(int k = from; k >= to; k--)
                {
                    long num = i * k;
                    char[] chars = num.ToString().ToCharArray();
                    Array.Reverse(chars);
                    if (num.ToString() == new string(chars))
                    {
                        if(num > result)
                        {
                            result = num;
                        }
                    }
                }
            }
            return result;
        }
    }
}
