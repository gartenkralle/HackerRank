using System;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (h[i] > k)
                {
                    int diff = (h[i] - k);

                    sum += diff;
                    k += diff;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
