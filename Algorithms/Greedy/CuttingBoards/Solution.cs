using System;

namespace CuttingBoards
{
    class Program
    {
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int[] mn = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int m = mn[0];
                int n = mn[0];

                int[] cost_y = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                int[] cost_x = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

                int result = BoardCutting(cost_y, cost_x);

                Console.WriteLine(result);
            }
        }

        static int BoardCutting(int[] cost_y, int[] cost_x)
        {
            int costs = 0;

            Array.Sort(cost_x);
            Array.Reverse(cost_x);

            Array.Sort(cost_y);
            Array.Reverse(cost_y);

            int index_x = 0;
            int index_y = 0;

            int mod = 1000000007;

            while ((index_x != cost_x.Length) || (index_y != cost_y.Length))
            {
                if ((index_x != cost_x.Length) && (index_y != cost_y.Length))
                {
                    if (cost_x[index_x] > cost_y[index_y])
                    {
                        costs = (costs % mod) + (int)(((long)cost_x[index_x] * (index_y + 1)) % mod);
                        index_x++;
                    }
                    else
                    {
                        costs = (costs % mod) + (int)(((long)cost_y[index_y] * (index_x + 1)) % mod);
                        index_y++;
                    }
                }
                else if (index_x != cost_x.Length)
                {
                    costs = (costs % mod) + (int)(((long)cost_x[index_x] * (index_y + 1)) % mod);
                    index_x++;
                }
                else if (index_y != cost_y.Length)
                {
                    costs = (costs % mod) + (int)(((long)cost_y[index_y] * (index_x + 1)) % mod);
                    index_y++;
                }
            }

            return (costs % mod);
        }
    }
}
