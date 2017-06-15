using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                    mat[i, j] = Int32.Parse(row[j]);
            }

            int sum1 = 0;

            for (int i = 0; i < N; i++)
            {
                sum1 += mat[i, i];
            }

            int sum2 = 0;

            for (int i = 0; i < N; i++)
            {
                sum2 += mat[i, (N - 1) - i];
            }

            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
