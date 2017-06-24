using System;

namespace BeautifulTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nd = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nd[0];
            int d = nd[1];

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if ((Array.BinarySearch(a, a[i] + d) > 0) && (Array.BinarySearch(a, a[i] + 2 * d) > 0))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
