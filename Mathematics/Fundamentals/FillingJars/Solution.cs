using System;

namespace FillingJars
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int N = NM[0];
            int M = NM[1];

            long sum = 0;

            for (int i = 0; i < M; i++)
            {
                int[] abk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int a = abk[0];
                int b = abk[1];
                int k = abk[2];
                
                sum += (((b - a) + 1) * (long)k);
            }

            Console.WriteLine((sum / N));
        }
    }
}
