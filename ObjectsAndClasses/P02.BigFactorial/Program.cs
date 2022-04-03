﻿using System;
using System.Numerics;

namespace P02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);

            
        }
    }
}
