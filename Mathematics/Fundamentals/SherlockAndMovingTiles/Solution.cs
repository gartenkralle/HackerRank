using System;

namespace SherlockAndMovingTiles
{
    static class Program
    {
        static void Main(String[] args)
        {
            int[] LSS = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int L = LSS[0];
            int S1 = LSS[1];
            int S2 = LSS[2];

            int Q = int.Parse(Console.ReadLine());
            long[] q = new long[Q];

            for (int i = 0; i < Q; i++)
            {
                q[i] = long.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Q; i++)
            {
                int s = Math.Abs(S1 - S2);

                long a = (long)s * s;
                double b = -2 * Math.Sqrt(2) * ((long)L * s);
                long c = -2 * (q[i] - ((long)L * L));

                double t = (-b - Math.Sqrt((b * b) - ((double)4 * a * c))) / (2 * a);

                Console.WriteLine(t.ToString("0.####"));
            }
        }
    }
}
