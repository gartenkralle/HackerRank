using System;

namespace BotSavesPrincess2
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] position = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            String[] grid = new String[n];

            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            nextMove(n, position[0], position[1], grid);
        }

        static void nextMove(int n, int r, int c, String[] grid)
        {
            int[] m = new int[2];
            int[] p = new int[2];

            calcPosition(grid, n, m, "m");
            calcPosition(grid, n, p, "p");

            if (m[0] > p[0])
            {
                Console.WriteLine("LEFT");
            }
            else if (m[0] < p[0])
            {
                Console.WriteLine("RIGHT");
            }
            else if (m[1] > p[1])
            {
                Console.WriteLine("UP");
            }
            else if (m[1] < p[1])
            {
                Console.WriteLine("DOWN");
            }
        }

        static void calcPosition(String[] grid, int n, int[] pos, string s)
        {
            for (int i = 0; i < n; i++)
            {
                if (grid[i].Contains(s))
                {
                    pos[0] = grid[i].IndexOf(s);
                    pos[1] = i;
                }
            }
        }
    }
}
