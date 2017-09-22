using Project_Euler.Problem_Solver;
using System;
using System.Collections.Generic;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1:");
            Problem_01 p1 = new Problem_01();
            Console.WriteLine(p1.Multiples(1_000, 3, 5));
            Console.WriteLine("\nProblem 2:");
            Problem_02 p2 = new Problem_02();
            Console.WriteLine(p2.EvenFibonacci(4_000_000));
            Console.WriteLine("\nProblem 3:");
            Problem_03 p3 = new Problem_03();
            Console.WriteLine(p3.Calculate(600_851_475_143));
            Console.WriteLine("\nProblem 4:");
            Problem_04 p4 = new Problem_04();
            Console.WriteLine(p4.PalindromeNumber(999, 100));
            Console.WriteLine("\nProblem 5:");
            Problem_05 p5 = new Problem_05();
            Console.WriteLine(p5.SmallestNumber(1, 20));
            Console.WriteLine("\nProblem 6:");
            Problem_06 p6 = new Problem_06();
            Console.WriteLine(p6.Squares(1, 100));
            Console.WriteLine("\nProblem 7:");
            Problem_07 p7 = new Problem_07();
            Console.WriteLine(p7.WhatIsThePrime(10_001));
            Console.WriteLine("\nProblem 8:");
            Problem_08 p8 = new Problem_08();
            Console.WriteLine(p8.Largest(13));
            Console.WriteLine("\nProblem 9:");
            Problem_09 p9 = new Problem_09();
            Console.WriteLine(p9.FindABC(1000));
            Console.WriteLine("\nProblem 10:");
            Problem_10 p10 = new Problem_10();
            Console.WriteLine(p10.SumOfPrimes(2_000_000));
            Console.ReadKey();
        }
    }
}
