using System;
using System.Collections.Generic;

namespace AbsolutePermutation
{
    class Program
    {
        private static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = nk[0];
                int k = nk[1];

                Console.WriteLine(AbsolutePermutationString(n, k));
            }
        }

        static string AbsolutePermutationString(int n, int k)
        {
            int[] result = AbsolutePermutation(n, k);

            return result == null ? "-1" : string.Join(" ", result);
        }

        static int[] AbsolutePermutation(int n, int k)
        {
            int[] result = new int[n];
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 1; i <= n; i++)
            {
                hashSet.Add(i);
            }

            for (int i = 1; i <= n; i++)
            {
                if (hashSet.Contains(i - k))
                {
                    hashSet.Remove(i - k);
                    result[i - 1] = i - k;
                }
                else if (hashSet.Contains(i + k))
                {
                    hashSet.Remove(i + k);
                    result[i - 1] = i + k;
                }
                else
                {
                    return null;
                }
            }

            return result;
        }
    }
}
