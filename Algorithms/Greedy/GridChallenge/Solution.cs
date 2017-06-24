using System;

namespace GridChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(Console.ReadLine());

                char[][] Grid = new char[N][];

                for (int j = 0; j < N; j++)
                    Grid[j] = Console.ReadLine().ToCharArray();

                if (isSorted(Grid, N))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        static bool isSorted(char[][] Grid, int N)
        {
            for (int j = 0; j < N; j++)
                Array.Sort(Grid[j]);

            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < (N - 1); k++)
                {
                    if (Grid[k][j] > Grid[k + 1][j])
                        return false;
                }
            }

            return true;
        }
    }
}
