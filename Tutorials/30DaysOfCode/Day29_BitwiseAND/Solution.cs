using System;

namespace Day29_BitwiseAND
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = nk[0];
                int k = nk[1];

                int max = 0;

                for (int j = 1; j <= (n - 1); j++)
                {
                    for (int l = (j + 1); l <= n; l++)
                    {
                        int bitwiseAnd = j & l;

                        if ((bitwiseAnd > max) && (bitwiseAnd < k))
                            max = bitwiseAnd;
                    }
                }

                Console.WriteLine(max);
            }
        }
    }
}
