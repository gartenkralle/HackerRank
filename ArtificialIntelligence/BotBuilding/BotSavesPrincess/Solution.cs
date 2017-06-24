using System;
using System.Collections.Generic;
using System.IO;

class BotSavesPrincess
{
    static void Main(String[] args)
    {
        int m;

        m = Int32.Parse(Console.ReadLine());

        String[] grid = new String[m];

        for (int i = 0; i < m; i++)
        {
            grid[i] = Console.ReadLine();
        }

        displayPathtoPrincess(m, grid);
    }

    static void displayPathtoPrincess(int n, String[] grid)
    {
        int[] m = new int[2];
        int[] p = new int[2];

        calcPosition(grid, n, m, "m");
        calcPosition(grid, n, p, "p");

        while (m[0] > p[0])
        {
            Console.WriteLine("LEFT");
            m[0]--;
        }
        while (m[0] < p[0])
        {
            Console.WriteLine("RIGHT");
            m[0]++;
        }
        while (m[1] > p[1])
        {
            Console.WriteLine("UP");
            m[1]--;
        }
        while (m[1] < p[1])
        {
            Console.WriteLine("DOWN");
            m[1]++;
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
