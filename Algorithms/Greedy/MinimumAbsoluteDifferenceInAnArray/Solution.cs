using System;

namespace MinimumAbsoluteDifferenceInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int minDistance = int.MaxValue;

            Array.Sort(a);

            for (int i = 0; i < (n - 1); i++)
            {
                int distance = a[i + 1] - a[i];

                if (distance < minDistance)
                    minDistance = distance;
            }

            Console.WriteLine(minDistance);
        }
    }
}
