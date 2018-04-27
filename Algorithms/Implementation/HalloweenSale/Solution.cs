using System;

namespace HalloweenSale
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] pdms = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int p = pdms[0];
            int d = pdms[1];
            int m = pdms[2];
            int s = pdms[3];

            int answer = HowManyGames(p, d, m, s);

            Console.WriteLine(answer);
        }

        static int HowManyGames(int p, int d, int m, int s)
        {
            int count = 0;

            int d_count = (p - m) / d;

            if ((s - p) >= 0)
            {
                count++;

                s -= p;
            }

            while ((s - p) >= 0)
            {
                count++;

                if (d_count > 0)
                {
                    p -= d;
                    s -= p;

                    d_count--;
                }
                else
                {
                    s -= m;
                    p = m;
                }
            }

            return count;
        }
    }
}
