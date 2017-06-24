using System;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int K = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
                arr[i] = Int32.Parse(Console.ReadLine());

            Array.Sort(arr);

            int min = Int32.MaxValue;

            for (int i = 0; i < (N - K + 1); i++)
            {
                int tmp = arr[i + K - 1] - arr[i];

                if (tmp < min)
                    min = tmp;
            }

            Console.WriteLine(min);
        }
    }
}
