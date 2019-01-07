using System;

namespace SherlockAndGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                Console.WriteLine(Solve(a));
            }
        }

        static string Solve(int[] a)
        {
            if (a.Length == 1)
                return "NO";

            int greatestCommonDivisor = GreatestCommonDivisor(a[0], a[1]);

            for (int i = 0; i < a.Length; i++)
            {
                int currentGreatestCommonDivisor = GreatestCommonDivisor(a[i], greatestCommonDivisor);

                if (currentGreatestCommonDivisor < greatestCommonDivisor)
                {
                    greatestCommonDivisor = currentGreatestCommonDivisor;
                }
            }

            if (greatestCommonDivisor == 1)
            {
                return "YES";
            }

            return "NO";
        }

        static int GreatestCommonDivisor(int a, int b)
        {
            int residual;

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
