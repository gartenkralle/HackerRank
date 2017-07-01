using System;

namespace FlippingTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int[][] matrix = new int[2 * n][];

                for (int j = 0; j < (2 * n); j++)
                {
                    matrix[j] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                }

                Console.WriteLine(GetUpperLeftMaxSum(matrix));
            }
        }

        static int GetUpperLeftMaxSum(int[][] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.Length / 2; i++)
            {
                for (int j = 0; j < matrix.Length / 2; j++)
                {
                    sum += GetMaxOfFour(matrix[i][j], matrix[(matrix.Length - 1) - i][j], matrix[i][(matrix.Length - 1) - j], matrix[(matrix.Length - 1) - i][(matrix.Length - 1) - j]);
                }
            }

            return sum;
        }

        private static int GetMaxOfFour(int v1, int v2, int v3, int v4)
        {
            return GetMaxOfTwo(GetMaxOfTwo(v1, v2), GetMaxOfTwo(v3, v4));
        }

        private static int GetMaxOfTwo(int v1, int v2)
        {
            return v1 > v2 ? v1 : v2;
        }
    }
}
