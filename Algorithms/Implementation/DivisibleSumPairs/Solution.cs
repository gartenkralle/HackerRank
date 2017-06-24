using System;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int count = 0;

            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = (i + 1); j < n; j++)
                {
                    if (((a[i] + a[j]) % k) == 0)
                        count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
