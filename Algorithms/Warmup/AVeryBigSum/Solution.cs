using System;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            long result = AVeryBigSum(n, arr);

            Console.WriteLine(result);
        }

        static long AVeryBigSum(int n, long[] arr)
        {
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
