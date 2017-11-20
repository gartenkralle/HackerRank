using System;

namespace SherlockAndPermutations
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            int[][] pascal = GetPascalsTriangle(2000);

            for (int i = 0; i < T; i++)
            {
                int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = NM[0];
                int M = NM[1];

                Console.WriteLine(pascal[N + M - 1][M - 1]);
            }
        }

        static int[][] GetPascalsTriangle(int size)
        {
            int[][] pascal = new int[size][];

            for (int i = 0; i < size; i++)
            {
                pascal[i] = new int[i + 1];
                pascal[i][0] = 1;
                pascal[i][i] = 1;
            }

            for (int i = 2; i < size; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    pascal[i][j] = (pascal[i - 1][j - 1] + pascal[i - 1][j]) % 1000000007;
                }
            }

            return pascal;
        }
    }
}
