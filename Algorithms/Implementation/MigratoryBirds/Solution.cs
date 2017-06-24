using System;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte[] b = Array.ConvertAll(Console.ReadLine().Split(' '), byte.Parse);

            byte mostCommon = 0;
            int biggestCount = 0;

            int[] types = new int[5 + 1];

            foreach (byte bird in b)
                types[bird]++;

            for (byte i = 1; i < (5 + 1); i++)
            {
                if (types[i] > biggestCount)
                {
                    biggestCount = types[i];
                    mostCommon = i;
                }
            }

            Console.WriteLine(mostCommon);
        }
    }
}
