using System;

namespace PoissonDistributionI
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            float mean = 2.5f;

            double probability = (Math.Pow(mean, X) / Faculty(X)) * Math.Pow(Math.E, -mean);

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
