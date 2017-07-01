using System;
using System.Linq;

namespace RectangularGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                a[i] = ab[0];
                b[i] = ab[1];
            }

            Console.WriteLine((long)a.Min() * b.Min());
        }
    }
}
