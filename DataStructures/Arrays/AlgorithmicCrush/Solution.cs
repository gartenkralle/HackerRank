using System;

namespace AlgorithmicCrush
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int N = NM[0];
            int M = NM[1];

            int[] arr = new int[N + 1];

            for (int i = 0; i < M; i++)
            {
                int[] abk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int a = abk[0];
                int b = abk[1];
                int k = abk[2];

                arr[a - 1] += k;
                arr[b] -= k;
            }

            long max = 0;
            long sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += arr[i];

                if (sum > max)
                    max = sum;
            }

            Console.WriteLine(max);
        }
    }
}
