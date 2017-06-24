using System;
using System.Collections.Generic;
using System.Linq;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int N = NK[0];
            int K = NK[1];

            List<int> priceOfAnyToy = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();

            priceOfAnyToy.Sort();

            int sum = 0;
            int count = 0;

            for (int i = 0; (sum <= K) && (i < N); i++)
            {
                sum += priceOfAnyToy[i];
                count++;

                if (sum > K)
                {
                    sum -= priceOfAnyToy[i];
                    count--;
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
