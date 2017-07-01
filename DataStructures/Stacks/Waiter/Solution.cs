using System;
using System.Collections.Generic;

namespace Waiter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NQ = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int N = NQ[0];
            int Q = NQ[1];

            Stack<int>[] A = new Stack<int>[Q + 1];
            Stack<int>[] B = new Stack<int>[Q + 1];

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            A[0] = new Stack<int>(arr);

            for (int i = 1; i <= Q; i++)
            {
                A[i] = new Stack<int>();
                B[i] = new Stack<int>();
            }

            int[] primes = GetPrimes(1200);

            for (int i = 0; i < Q; i++)
            {
                while (A[i].Count != 0)
                {
                    int number = A[i].Pop();

                    if (number % primes[i] == 0)
                    {
                        B[i + 1].Push(number);
                    }
                    else
                    {
                        A[i + 1].Push(number);
                    }
                }
            }

            for (int i = 1; i <= Q; i++)
            {
                while (B[i].Count != 0)
                {
                    Console.WriteLine(B[i].Pop());
                }
            }

            while (A[Q].Count != 0)
            {
                Console.WriteLine(A[Q].Pop());
            }
        }

        private static int[] GetPrimes(int amountPrimes)
        {
            int count = 0;
            int curPrime = 0;

            List<int> primes = new List<int>();

            while (curPrime < amountPrimes)
            {
                count++;

                if (IsPrime(count, primes))
                {
                    primes.Add(count);
                    curPrime++;
                }
            }

            return primes.ToArray();
        }

        private static bool IsPrime(int number, List<int> primeBefore)
        {
            if (primeBefore.Count != 0)
            {
                int sqrt = (int)Math.Sqrt(number);

                for (int i = 0; primeBefore[i] <= sqrt; i++)
                {
                    if ((number % primeBefore[i]) == 0)
                        return false;
                }
            }

            if (number < 2)
                return false;

            return true;
        }
    }
}
