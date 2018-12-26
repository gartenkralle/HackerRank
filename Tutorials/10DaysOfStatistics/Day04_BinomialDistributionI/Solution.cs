using System;

namespace BinomialDistributionI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int k = 3;
            double p = 1.09 / (1.09 + 1);
            double q = 1 - p;

            double probability = 0;

            for (int x = k; x <= n; x++)
            {
                int nk = Faculty(n) / (Faculty(x) * Faculty(n - x));
                probability += nk * Math.Pow(p, x) * Math.Pow(q, n - x);
            }

            Console.WriteLine(probability.ToString("0.000"));
        }

        static int Faculty(int n)
        {
            if (n == 0)
                return 1;

            return n * Faculty(n - 1);
        }
    }
}
