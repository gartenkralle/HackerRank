using System;
using System.Collections.Generic;
using System.Linq;

namespace Quartiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] X = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] F = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> S = new List<int>();

            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < F[i]; j++)
                {
                    S.Add(X[i]);
                }
            }

            int[] s = S.ToArray();

            Array.Sort(s);

            Console.WriteLine((Quantile.GetQuantile(s, QuantileType.Q3) - Quantile.GetQuantile(s, QuantileType.Q1)).ToString("0.0"));
        }

        static class Quantile
        {
            public static float GetQuantile(int[] arr, QuantileType q)
            {
                float median = 0;

                switch (q)
                {
                    case QuantileType.Q1:
                        int endIndex = (arr.Length / 2) - 1;

                        median = GetMedian(GetSubArray(arr, 0, endIndex));
                        break;

                    case QuantileType.Q2:
                        median = GetMedian(GetSubArray(arr, 0, arr.Length - 1));
                        break;

                    case QuantileType.Q3:
                        int startIndex;

                        if ((arr.Length % 2) == 0)
                            startIndex = arr.Length / 2;
                        else
                            startIndex = (arr.Length / 2) + 1;

                        median = GetMedian(GetSubArray(arr, startIndex, arr.Length - 1));
                        break;
                }

                return median;
            }

            private static int[] GetSubArray(int[] arr, int startIndex, int endIndex)
            {
                int length = endIndex - startIndex + 1;

                return arr.Skip(startIndex).Take(length).ToArray();
            }

            private static float GetMedian(int[] arr)
            {
                int median = arr[arr.Length / 2];

                if ((arr.Length % 2) == 0)
                {
                    median += arr[(arr.Length / 2) - 1];
                    median /= 2;
                }

                return median;
            }
        }

        enum QuantileType
        {
            Q1, Q2, Q3
        }
    }
}
