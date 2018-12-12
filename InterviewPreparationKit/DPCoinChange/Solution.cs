using System;

namespace DPCoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nm[0];
            int m = nm[1];

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(c);

            Console.WriteLine(GetWays(c, n));
        }

        static long GetWays(int[] c, int n)
        {
            long[,] dp = new long[c.Length, n + 1];

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    dp[i, j] = -1;
                }
            }

            return GetWays(c, dp, 0, n);
        }

        static long GetWays(int[] c, long[,] dp, int index, int n)
        {
            if ((n < 0) || (index >= c.Length))
                return 0;
            else if ((c[index] == n) || (n == 0))
                return 1;
            else if (dp[index, n] != -1)
                return dp[index, n];

            dp[index, n] = GetWays(c, dp, index, n - c[index]) + GetWays(c, dp, index + 1, n);

            return dp[index, n];
        }
    }
}
