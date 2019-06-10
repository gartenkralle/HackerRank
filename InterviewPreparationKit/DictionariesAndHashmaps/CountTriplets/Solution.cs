using System;
using System.Collections.Generic;

namespace CountTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nr[0];
            int r = nr[1];

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(CountTriplets(arr, r));
        }

        static long CountTriplets(int[] arr, int r)
        {
            long count = 0;

            Dictionary<int, long> frequencies;

            long[] smallerCount = new long[arr.Length];
            long[] largerCount = new long[arr.Length];

            frequencies = new Dictionary<int, long>();

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % r == 0) && frequencies.ContainsKey(arr[i] / r))
                    smallerCount[i] = frequencies[arr[i] / r];
                else
                    smallerCount[i] = 0;

                if (!frequencies.ContainsKey(arr[i]))
                    frequencies.Add(arr[i], 1);
                else
                    frequencies[arr[i]]++;
            }

            frequencies = new Dictionary<int, long>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (frequencies.ContainsKey(r * arr[i]))
                    largerCount[i] = frequencies[r * arr[i]];
                else
                    largerCount[i] = 0;

                if (!frequencies.ContainsKey(arr[i]))
                    frequencies.Add(arr[i], 1);
                else
                    frequencies[arr[i]]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                count += smallerCount[i] * largerCount[i];
            }

            return count;
        }
    }
}
