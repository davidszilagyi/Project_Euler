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
            Problem_1 p1 = new Problem_1();
            Console.WriteLine(p1.Multiples(1000, 3, 5));
            Console.WriteLine("\nProblem 2:");
            Problem_2 p2 = new Problem_2();
            Console.WriteLine(p2.EvenFibonacci(4000000));
            Console.WriteLine("\nProblem 3:");
            Problem_3 p3 = new Problem_3();
            Console.WriteLine(p3.Calculate(600851475143));
            Console.WriteLine("\nProblem 4:");
            Problem_4 p4 = new Problem_4();
            Console.WriteLine(p4.PalindromeNumber(999, 100));
            Console.WriteLine("\nProblem 5:");
            Problem_5 p5 = new Problem_5();
            Console.WriteLine(p5.SmallestNumber(1, 20));
            Console.WriteLine("\nProblem 6:");
            Problem_6 p6 = new Problem_6();
            Console.WriteLine(p6.Squares(1, 100));
            Console.WriteLine("\nProblem 7:");
            Problem_7 p7 = new Problem_7();
            Console.WriteLine(p7.WhatIsThePrime(10001));
            Console.WriteLine("\nProblem 8:");
            Problem_8 p8 = new Problem_8();
            Console.WriteLine(p8.Largest(13));
            Console.ReadKey();
        }
    }
}
