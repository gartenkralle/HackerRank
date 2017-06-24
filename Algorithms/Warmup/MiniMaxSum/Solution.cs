using System;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(a);

            long minSum = (long)a[0] + a[1] + a[2] + a[3];
            long maxSum = (long)a[1] + a[2] + a[3] + a[4];

            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
