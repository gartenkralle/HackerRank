using System;
using System.Collections.Generic;

namespace LeonardosPrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            int[] uniquePrimes = GetUniquePrimes(1000000000000000000);

            for (int i = 0; i < q; i++)
            {
                ulong n = ulong.Parse(Console.ReadLine());

                int count = 0;
                ulong product = 1;

                for (int j = 0; (product <= n) && (j < uniquePrimes.Length); j++)
                {
                    product *= (ulong)uniquePrimes[j];
                    count++;
                }

                if (product > n)
                    count--;

                Console.WriteLine(count);
            }
        }

        static int[] GetUniquePrimes(ulong number)
        {
            List<int> primes = new List<int>();

            ulong product = 1;

            for (int i = 2; product <= number; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                    product *= (ulong)i;
                }
            }

            primes.RemoveAt(primes.Count - 1);

            return primes.ToArray();
        }

        static bool IsPrime(long number)
        {
            long sqrt = (long)(Math.Sqrt(number));
            long div = 3;

            if (number < 2)
                return false;

            if ((number != 2) && ((number % 2) == 0))
                return false;

            while (div <= sqrt)
            {
                if ((number % div) == 0)
                    return false;
                else
                    div += 2;
            }

            return true;
        }
    }
}
