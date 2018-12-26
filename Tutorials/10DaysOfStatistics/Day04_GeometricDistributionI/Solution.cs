using System;

namespace GeometricDistributionI
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1.0 / 3.0;
            int n = 5;

            Console.WriteLine(GetProbability(n, p).ToString("0.000"));
        }

        static double GetProbability(int n, double p)
        {
            double q = 1 - p;

            return Math.Pow(q, n - 1) * p;
        }
    }
}
