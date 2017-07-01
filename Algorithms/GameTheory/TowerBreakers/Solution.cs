using System;

namespace TowerBreakers
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int N = NM[0];
                int M = NM[1];

                if (((N % 2) == 1) && (M > 1))
                    Console.WriteLine(1);
                else
                    Console.WriteLine(2);
            }
        }
    }
}
