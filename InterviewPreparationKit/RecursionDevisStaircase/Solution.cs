using System;

namespace RecursionDevisStaircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxStairs = 36;
            int[,] c = new int[maxStairs + 1, 3];
            c[0, 0] = 1;

            for (int i = 1; i <= maxStairs; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, 0] += c[i - 1, j];
                }

                c[i, 1] = c[i - 1, 0];
                c[i, 2] = c[i - 1, 1];
            }

            int s = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(c[n, 0]);
            }
        }
    }
}
