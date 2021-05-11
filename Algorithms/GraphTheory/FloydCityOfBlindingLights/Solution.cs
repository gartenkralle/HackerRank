using System;

namespace FloydCityOfBlindingLights
{
    class Solution
    {
        public static void Main()
        {
            string[] count = Console.ReadLine().TrimEnd().Split(' ');

            int nodeCount = Convert.ToInt32(count[0]);
            int edgeCount = Convert.ToInt32(count[1]);

            int[][] matrix = GetEmptyMatrix(400);
            PopulateMatrix(matrix, int.MaxValue);

            for (int i = 0; i < edgeCount; i++)
            {
                int[] data = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), int.Parse);
                matrix[data[0]][data[1]] = data[2];
            }

            CalculateShortestPairMatrix(matrix);

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < q; i++)
            {
                int[] query = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), int.Parse);

                Console.WriteLine(GetShortestPair(matrix, query[0], query[1]));
            }
        }

        private static int[][] GetEmptyMatrix(int size)
        {
            int[][] matrix = new int[size + 1][];

            for (int i = 1; i < matrix.Length; i++)
            {
                matrix[i] = new int[matrix.Length];
            }

            return matrix;
        }

        private static void PopulateMatrix(int[][] matrix, int value)
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    matrix[i][j] = value;
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                matrix[i][i] = 0;
            }
        }

        private static void CalculateShortestPairMatrix(int[][] matrix)
        {
            for (int k = 1; k < matrix.Length; k++)
            {
                for (int i = 1; i < matrix.Length; i++)
                {
                    if (k != i)
                    {
                        for (int j = 1; j < matrix.Length; j++)
                        {
                            if (k != j && matrix[i][k] != int.MaxValue && matrix[k][j] != int.MaxValue)
                            {
                                int detour = matrix[i][k] + matrix[k][j];

                                if (detour < matrix[i][j])
                                {
                                    matrix[i][j] = detour;
                                }
                            }
                        }
                    }
                }
            }
        }

        private static int GetShortestPair(int[][] matrix, int firstNode, int secondNode)
        {
            return matrix[firstNode][secondNode] == int.MaxValue ? -1 : matrix[firstNode][secondNode];
        }
    }
}
