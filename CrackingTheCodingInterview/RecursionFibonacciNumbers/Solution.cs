using System;

namespace RecursionFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibs = new int[40];

            fibs[0] = 0;
            fibs[1] = 1;

            for (int i = 2; i < fibs.Length; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(fibs[n]);
        }
    }
}
