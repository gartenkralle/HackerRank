using System;

namespace BricksGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                long result = BricksGame(arr);

                Console.WriteLine(result);
            }
        }

        static long BricksGame(int[] arr)
        {
            int[] counts = new int[arr.Length];
            long[] sums = new long[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                long sum3 = GetSum(arr, i, 3, counts, sums);
                long sum2 = GetSum(arr, i, 2, counts, sums);
                long sum1 = GetSum(arr, i, 1, counts, sums);

                if ((sum3 >= sum2) && (sum3 >= sum1))
                {
                    counts[i] = 3;
                    sums[i] = sum3;
                }
                else if ((sum2 >= sum3) && (sum2 >= sum1))
                {
                    counts[i] = 2;
                    sums[i] = sum2;
                }
                else
                {
                    counts[i] = 1;
                    sums[i] = sum1;
                }
            }

            return sums[0];
        }

        private static long GetSum(int[] arr, int index, int size, int[] counts, long[] sums)
        {
            long sum = 0;

            for (int i = index; i < (index + size) && i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if ((index + size < arr.Length) && (index + size + counts[index + size] < arr.Length))
            {
                sum += sums[index + size + counts[index + size]];
            }

            return sum;
        }
    }
}
