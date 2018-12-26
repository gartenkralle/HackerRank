using System;

namespace StandardDeviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] X = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(GetStandardDeviation(X).ToString("0.0"));
        }

        static float GetMean(int[] arr)
        {
            int sum = 0;

            foreach (int number in arr)
            {
                sum += number;
            }

            return sum / (float)arr.Length;
        }

        static float GetStandardDeviation(int[] arr)
        {
            float mean = GetMean(arr);

            long sumQuadraticDifference = 0;

            foreach (int number in arr)
            {
                sumQuadraticDifference += (long)Math.Pow(number - mean, 2);
            }

            return (float)Math.Sqrt(sumQuadraticDifference / arr.Length);
        }
    }
}
