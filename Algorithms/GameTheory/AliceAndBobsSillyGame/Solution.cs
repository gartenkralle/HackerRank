using System;
using System.Collections.Generic;
using System.Linq;

namespace AliceAndBobsSillyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());

            int amount = 100000;

            List<int> primes = GetPrimes(amount);

            for (int i = 0; i < g; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int searchResult = primes.BinarySearch(n);
                int count = (searchResult < 0) ? ~searchResult : searchResult + 1;
                List<int> subset = primes.GetRange(0, count);

                String result;

                if ((subset.Count % 2) == 0)
                    result = "Bob";
                else
                    result = "Alice";

                Console.WriteLine(result);
            }
        }

        static List<int> GetPrimes(int amount)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i < amount; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }

            return primes;
        }

        static bool IsPrime(int number)
        {
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 2; i <= sqrt; i++)
            {
                if ((number % i) == 0)
                    return false;
            }

            return true;
        }
    }
}
