using System;
using System.Collections.Generic;
using System.Linq;

namespace MansaAndStones
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(String.Join(" ", Stones(n, a, b)));
            }
        }

        static int[] Stones(int n, int a, int b)
        {
            SortedSet<int> set = new SortedSet<int>();

            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            for (int i = 0; i < n; i++)
            {
                set.Add((min * (n - 1 - i)) + (max * i));
                set.Add((max * (n - 1 - i)) + (min * i));
            }

            return set.ToArray();
        }
    }
}
