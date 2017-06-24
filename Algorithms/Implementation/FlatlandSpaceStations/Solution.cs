using System;

namespace FlatlandSpaceStations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nm[0];
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(c);

            int maxDistance = 0;

            for (int i = 0; i < (c.Length - 1); i++)
            {
                int distance = (c[i + 1] - c[i]) / 2;

                if (distance > maxDistance)
                    maxDistance = distance;
            }

            int frontDistance = c[0];
            int backDistance = (n - 1) - c[c.Length - 1];

            if (frontDistance > maxDistance)
                maxDistance = frontDistance;

            if (backDistance > maxDistance)
                maxDistance = backDistance;

            Console.WriteLine(maxDistance);
        }
    }
}
