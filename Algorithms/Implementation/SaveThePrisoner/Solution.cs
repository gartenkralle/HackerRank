using System;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] NMS = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = NMS[0];
                int M = NMS[1];
                int S = NMS[2];

                int last = ((S + M - 2) % N) + 1;

                Console.WriteLine(last);
            }
        }
    }
}
