using System;

namespace PriyankaAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] w = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            Array.Sort(w);

            int groups = 1;
            int current = w[0];

            for (int i = 1; i < N; i++)
            {
                if ((current + 4) < w[i])
                {
                    groups++;
                    current = w[i];
                }
            }

            Console.WriteLine(groups);
        }
    }
}
