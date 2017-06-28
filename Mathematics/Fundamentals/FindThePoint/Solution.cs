using System;

namespace FindThePoint
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] pq = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int px = pq[0];
                int py = pq[1];
                int qx = pq[2];
                int qy = pq[3];

                Console.WriteLine("{0} {1}", (qx - px) + qx, (qy - py) + qy);
            }
        }
    }
}
