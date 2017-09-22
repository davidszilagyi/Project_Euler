using Project_Euler.Problem_Solver;
using System;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1:");
            Problem_1 p1 = new Problem_1();           
            Console.WriteLine(p1.Multiples(1000, 3, 5));
            Console.WriteLine("\nProblem 2:");
            Problem_2 p2 = new Problem_2();
            Console.WriteLine(p2.EvenFibonacci(4000000));
            Console.ReadKey();
        }
    }
}
