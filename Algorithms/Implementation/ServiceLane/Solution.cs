using System;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nt = Console.ReadLine().Split(' ');
            int N = Int32.Parse(nt[0]);
            int T = Int32.Parse(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            for (int k = 0; k < T; k++)
            {
                string[] ij = Console.ReadLine().Split(' ');
                int i = Int32.Parse(ij[0]);
                int j = Int32.Parse(ij[1]);

                int max = Int32.MaxValue;

                while (i <= j)
                {
                    if (width[i] < max)
                        max = width[i];

                    i++;
                }

                Console.WriteLine(max);
            }
        }
    }
}
