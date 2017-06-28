using System;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(arr);

            int count = 0;

            for (int i = 0; i < (n - 1); i++)
            {
                if (Array.BinarySearch(arr, (i + 1), n - (i + 1), arr[i] + k) >= 0)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
