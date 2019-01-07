using System;

namespace PossiblePath
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                Console.WriteLine(Solve(arr[0], arr[1], arr[2], arr[3]));
            }
        }

        static string Solve(long a, long b, long x, long y)
        {
            return (GreatestCommonDivisor(a, b) == GreatestCommonDivisor(x, y)) ? "YES" : "NO";
        }

        static long GreatestCommonDivisor(long a, long b)
        {
            long residual;

            if (a == 0)
            {
                return Math.Abs(b);
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            do
            {
                residual = a % b;
                a = b;
                b = residual;
            }
            while (b != 0);

            return Math.Abs(a);
        }
    }
}
