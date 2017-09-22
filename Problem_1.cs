using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Problem_1
    {
        public int Multiples(int to, params int[] numbers)
        {
            int result = 0;
            for(int i = 0; i < to; i++)
            {
                foreach(int number in numbers)
                {
                    if(i % number == 0)
                    {
                        result += i;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
