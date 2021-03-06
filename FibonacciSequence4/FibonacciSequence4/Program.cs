﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence4
{
    class Program
    {
        public static int NthFibonacciNumber(int n)
        {
            if ((n == 0)) || (n == 1))
            {
                return n;
            }

            else
            {
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter the nth number of the Fibonacci Series: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = number - 1;
            // We have to decrement the lenght because the series starts with 0

            Console.Write(NthFibonacciNumber(number));
            Console.ReadKey();
        }
    }
}
