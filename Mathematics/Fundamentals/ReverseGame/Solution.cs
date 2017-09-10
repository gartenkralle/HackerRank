using System;

namespace ReverseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] NK = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                int N = NK[0];
                int K = NK[1];

                int index;

                if (K >= (N / 2))
                    index = 2 * ((N - 1) - K);
                else
                {
                    if ((N % 2) == 0)
                        index = (N - 1) - (2 * (((N - 1) / 2) - K));
                    else
                        index = (N - 2) - (2 * (((N - 2) / 2) - K));
                }

                Console.WriteLine(index);
            }
        }
    }
}
