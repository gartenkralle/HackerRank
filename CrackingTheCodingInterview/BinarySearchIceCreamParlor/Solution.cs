using System;

namespace BinarySearchIceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int M = Int32.Parse(Console.ReadLine());
                int N = Int32.Parse(Console.ReadLine());
                string[] arr = Console.ReadLine().Split(' ');
                int[] C = new int[N];

                for (int j = 0; j < N; j++)
                    C[j] = Int32.Parse(arr[j]);

                printIndices(M, N, C);
            }
        }

        static void printIndices(int M, int N, int[] C)
        {
            for (int j = 0; j < N; j++)
            {
                for (int k = (j + 1); k < N; k++)
                {
                    if (C[j] + C[k] == M)
                    {
                        Console.WriteLine((j + 1) + " " + (k + 1));
                        return;
                    }
                }
            }
        }
    }
}
