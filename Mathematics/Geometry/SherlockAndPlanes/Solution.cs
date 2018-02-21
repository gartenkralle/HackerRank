using System;
using System.Numerics;

namespace SherlockAndPlanes
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[][] arr = ReadMatrix();

                if (IsPlaneEqual(arr))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        private static int[][] ReadMatrix()
        {
            int[][] matrix = new int[4][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = GetIntArray();
            }

            return matrix;
        }

        private static int[] GetIntArray()
        {
            return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }

        private static bool IsPlaneEqual(int[][] matrix)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                int[] arr = new int[matrix.Length];

                for (int j = 0; j < matrix.Length; j++)
                {
                    arr[j] = matrix[j][i];
                }

                if (IsPlaneEqual(arr))
                    return true;
            }

            return false;
        }

        private static bool IsPlaneEqual(int[] arr)
        {
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                if (arr[i] != arr[i + 1])
                    return false;
            }

            return true;
        }
    }
}
