using Project_Euler.Problem_Solver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem_1 p1 = new Problem_1();           
            Console.WriteLine(p1.Multiples(1000, 3, 5));
            Console.ReadKey();
        }
    }
}
