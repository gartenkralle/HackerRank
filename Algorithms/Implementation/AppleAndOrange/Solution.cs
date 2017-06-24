using System;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(st[0]);
            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(ab[0]);
            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(mn[0]);
            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int appleCount = HitCount(apples, a, s, t);
            int orangeCount = HitCount(oranges, b, s, t);

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

        static int HitCount(int[] arr, int tree, int s, int t)
        {
            int count = 0;

            foreach(int d in arr)
            {
                int pos = tree + d;

                if ((pos >= s) && (pos <= t))
                    count++;
            }

            return count;
        }
    }
}
