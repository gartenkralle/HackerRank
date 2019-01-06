using System;

namespace SumarAndTheFloatingRocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Console.WriteLine(Solve(arr[0], arr[1], arr[2], arr[3]));
            }
        }

        static int Solve(int x1, int y1, int x2, int y2)
        {
            int deltaX = Math.Abs(x1 - x2);
            int deltaY = Math.Abs(y1 - y2);

            if ((deltaX == 0) || (deltaY == 0))
            {
                return deltaX + deltaY - 1;
            }

            int divisor = GreatestCommonDivisor(deltaX, deltaY);

            deltaX /= divisor;
            deltaY /= divisor;

            int distance = Math.Abs(x1 - x2) - 1;

            return distance / deltaX;
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
