using System;
using System.Collections.Generic;

namespace OrganizingContainersOfBalls
{
    class Program
    {
        private static void Main()
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int n = int.Parse(Console.ReadLine());

                int[][] matrix = new int[n][];

                for (int j = 0; j < n; j++)
                {
                    matrix[j] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                }

                Console.WriteLine(OrganizingContainers(matrix));
            }
        }

        private static string OrganizingContainers(int[][] matrix)
        {
            return IsOrganizable(matrix) ? "Possible" : "Impossible";
        }

        private static bool IsOrganizable(int[][] matrix)
        {
            Dictionary<long, int> rowDictionary = GetRowSumDictionary(matrix);
            Dictionary<long, int> columnDictionary = GetColumnSumDictionary(matrix);

            return IsEquals(rowDictionary, columnDictionary);
        }

        private static bool IsEquals(Dictionary<long, int> dictionary1, Dictionary<long, int> dictionary2)
        {
            if (dictionary1.Count != dictionary2.Count)
            {
                return false;
            }

            foreach (KeyValuePair<long, int> keyValuePair in dictionary1)
            {
                if (!dictionary2.ContainsKey(keyValuePair.Key))
                {
                    return false;
                }

                if (dictionary2[keyValuePair.Key] != keyValuePair.Value)
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<long, int> GetColumnSumDictionary(int[][] matrix)
        {
            Dictionary<long, int> dictionary = new Dictionary<long, int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                long sum = 0;

                for (int j = 0; j < matrix.Length; j++)
                {
                    sum += matrix[i][j];
                }

                AddSum(dictionary, sum);
            }

            return dictionary;
        }

        private static Dictionary<long, int> GetRowSumDictionary(int[][] matrix)
        {
            Dictionary<long, int> dictionary = new Dictionary<long, int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                long sum = 0;

                for (int j = 0; j < matrix.Length; j++)
                {
                    sum += matrix[j][i];
                }

                AddSum(dictionary, sum);
            }

            return dictionary;
        }

        private static void AddSum(Dictionary<long, int> dictionary, long sum)
        {
            if (dictionary.ContainsKey(sum))
            {
                dictionary[sum]++;
            }
            else
            {
                dictionary.Add(sum, 1);
            }
        }
    }
}
