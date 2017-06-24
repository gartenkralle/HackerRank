using System;

namespace MinimumDistances
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int minDistance = int.MaxValue;

            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = (i + 1); j < n; j++)
                {
                    int distance = Math.Abs(i - j);

                    if ((a[i] == a[j]) && (distance < minDistance))
                        minDistance = distance;
                }
            }

            if (minDistance == int.MaxValue)
                minDistance = -1;

            Console.WriteLine(minDistance);
        }
    }
}
