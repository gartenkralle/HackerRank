using System;
using System.Linq;

namespace Day1_Quartiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] arr;

            arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            Array.Sort(arr);

            Console.WriteLine(Quantile.getQuantile(arr, QuantileType.Q1));
            Console.WriteLine(Quantile.getQuantile(arr, QuantileType.Q2));
            Console.WriteLine(Quantile.getQuantile(arr, QuantileType.Q3));
        }

        static class Quantile
        {
            public static int getQuantile(int[] arr, QuantileType q)
            {
                int median = 0;

                switch (q)
                {
                    case QuantileType.Q1:
                        int endIndex = (arr.Length / 2) - 1;

                        median = getMedian(getSubArray(arr, 0, endIndex));
                        break;

                    case QuantileType.Q2:
                        median = getMedian(getSubArray(arr, 0, arr.Length - 1));
                        break;

                    case QuantileType.Q3:
                        int startIndex;

                        if((arr.Length % 2) == 0)
                            startIndex = arr.Length / 2;
                        else
                            startIndex = (arr.Length / 2) + 1;

                        median = getMedian(getSubArray(arr, startIndex, arr.Length - 1));
                        break;
                }

                return median;
            }

            private static int[] getSubArray(int[] arr, int startIndex, int endIndex)
            {
                int length = endIndex - startIndex + 1;

                return arr.Skip(startIndex).Take(length).ToArray();
            }

            private static int getMedian(int[] arr)
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
