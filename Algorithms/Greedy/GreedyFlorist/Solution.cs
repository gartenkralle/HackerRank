using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedyFlorist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int N = NK[0];
            int K = NK[1];

            List<int> costs = new List<int>();
            int[] customers = new int[K];

            costs = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();
            costs.Sort();

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += (customers[i % K] + 1) * costs[N - (i + 1)];
                customers[i % K]++;
            }

            Console.WriteLine(sum);
        }
    }
}
