using System;

namespace Day0_WeightedMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] X = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            int[] W = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int valueSum = 0;
            int weightSum = 0;
            float weightedMean;

            for (int i = 0; i < N; i++)
            {
                valueSum += (X[i] * W[i]);
            }

            for (int i = 0; i < N; i++)
            {
                weightSum += W[i];
            }

            weightedMean = (float)valueSum / weightSum;

            Console.WriteLine(String.Format("{0:0.0}", Math.Round(weightedMean, 1)));
        }
    }
}
