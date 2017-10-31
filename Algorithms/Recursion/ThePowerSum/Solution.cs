using System;

namespace ThePowerSum
{
    class Program
    {
        static void Main(String[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int count = CountPowerSum(X, N);

            Console.WriteLine(count);
        }

        private static int CountPowerSum(int X, int N)
        {
            int sqrt = (int)Math.Sqrt(X);

            int[] sqrts = new int[sqrt];

            for (int i = 1; i <= sqrt; i++)
            {
                sqrts[i - 1] = (int)Math.Pow(i, N);
            }

            int count = 0;
            int sum = 0;
            int index = -1;

            CountPowerSumRec(X, sqrts, index, sum, ref count);

            return count;
        }

        private static void CountPowerSumRec(int X, int[] sqrts, int index, int sum, ref int count)
        {
            if (sum == X)
            {
                count++;
            }
            if (sum >= X)
            {
                return;
            }

            while (index < (sqrts.Length - 1))
            {
                CountPowerSumRec(X, sqrts, index + 1, sum + sqrts[index + 1], ref count);
                index++;
            }
        }
    }
}
