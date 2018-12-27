using System;

namespace GeometricDistributionII
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1.0 / 3.0;
            int n = 5;

            Console.WriteLine(GetProbabilityIntegral(n, p, 1, n).ToString("0.000"));
        }

        static double GetProbabilityIntegral(int n, double p, int begin, int end)
        {
            double probability = 0;

            for (int i = begin; i <= end; i++)
            {
                probability += GetProbability(i, p);
            }

            return probability;
        }

        static double GetProbability(int n, double p)
        {
            double q = 1 - p;

            return Math.Pow(q, n - 1) * p;
        }
    }
}
