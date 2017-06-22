using System;
using System.Numerics;

namespace FibonacciModified
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            BigInteger A = Int32.Parse(arr[0]);
            BigInteger B = Int32.Parse(arr[1]);
            BigInteger N = Int32.Parse(arr[2]);


            BigInteger nth = A + (B * B);

            for (int i = 4; i <= N; i++)
            {
                A = B;
                B = nth;
                nth = A + (B * B);
            }

            Console.WriteLine(nth);
        }
    }
}
