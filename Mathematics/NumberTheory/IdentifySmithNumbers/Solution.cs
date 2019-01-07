using System;
using System.Collections.Generic;

namespace IdentifySmithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(Solve(N));
        }

        static int Solve(int n)
        {
            int[] primeFactors = GetPrimeFactors(n);

            return (SumOfDigits(n) == SumOfDigits(primeFactors)) ? 1 : 0;
        }

        private static int[] GetPrimeFactors(int n)
        {
            int[] possiblePrimeFactors = GetPrimes((int)Math.Sqrt(n));

            return GetPrimeFactors(n, possiblePrimeFactors);
        }

        private static int[] GetPrimeFactors(int n, int[] possiblePrimeFactors)
        {
            List<int> primeFactors = new List<int>();

            foreach (int possiblePrimeFactor in possiblePrimeFactors)
            {
                while (n % possiblePrimeFactor == 0)
                {
                    primeFactors.Add(possiblePrimeFactor);
                    n /= possiblePrimeFactor;
                }
            }

            if (n != 1)
                primeFactors.Add(n);

            return primeFactors.ToArray();
        }

        static int SumOfDigits(int[] a)
        {
            int sum = 0;

            foreach (int n in a)
            {
                sum += SumOfDigits(n);
            }

            return sum;
        }

        static int SumOfDigits(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return sum;
        }

        private static int[] GetPrimes(int until)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= until; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }

            return primes.ToArray();
        }

        static bool IsPrime(long number)
        {
            long sqrt = (long)Math.Sqrt(number);
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
