using System;

namespace PointsOnALine
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                x[i] = xy[0];
                y[i] = xy[1];
            }

            if (OnALine(x) || OnALine(y))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }

        static bool OnALine(int[] axis)
        {
            for (int i = 0; i < (axis.Length - 1); i++)
            {
                if (axis[i] != axis[i + 1])
                    return false;
            }

            return true;
        }
    }
}
