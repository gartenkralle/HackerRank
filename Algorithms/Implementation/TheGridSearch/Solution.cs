using System;

namespace TheGridSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] RC = Console.ReadLine().Split(' ');
                int R = int.Parse(RC[0]);
                int C = int.Parse(RC[1]);
                int[][] G = new int[R][];

                for (int j = 0; j < R; j++)
                {
                    G[j] = StringToIntArray(Console.ReadLine());
                }

                string[] rc = Console.ReadLine().Split(' ');
                int r = int.Parse(rc[0]);
                int c = int.Parse(rc[1]);
                int[][] P = new int[r][];

                for (int j = 0; j < r; j++)
                {
                    P[j] = StringToIntArray(Console.ReadLine());
                }

                if (GridSearch(G, P))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static int[] StringToIntArray(string s)
        {
            int[] arr = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = (int)char.GetNumericValue(s[i]);
            }

            return arr;
        }

        static bool GridSearch(int[][] G, int[][] P)
        {
            for (int i = 0; i < G.Length - P.Length + 1; i++)
            {
                for (int j = 0; j < G[0].Length - P[0].Length + 1; j++)
                {
                    if (IsEqual(G, P, i, j))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        static bool IsEqual(int[][] G, int[][] P, int row, int col)
        {
            for (int i = 0; i < P.Length; i++)
            {
                for (int j = 0; j < P[0].Length; j++)
                {
                    if (G[i + row][j + col] != P[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
