using System;

namespace BinomialDistributionII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int k = 2;
            double p = 0.12;

            Console.WriteLine(GetProbabilityIntegral(n, k, p, 0, k).ToString("0.000"));
            Console.WriteLine(GetProbabilityIntegral(n, k, p, k, n).ToString("0.000"));
        }

        static double GetProbabilityIntegral(int n, int k, double p, int begin, int end)
        {
            double probability = 0;

            for (int i = begin; i <= end; i++)
            {
                probability += GetProbability(n, i, p);
            }

            return probability;
        }

        static double GetProbability(int n, int k, double p)
        {
            double q = 1 - p;
            int nk = Faculty(n) / (Faculty(k) * Faculty(n - k));

            return nk * Math.Pow(p, k) * Math.Pow(q, n - k);
        }

        static int Faculty(int n)
        {
            if (n == 0)
                return 1;

            return n * Faculty(n - 1);
        }
    }
}
