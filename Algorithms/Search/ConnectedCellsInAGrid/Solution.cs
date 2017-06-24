using System;

namespace ConnectedCellsInAGrid
{
    class Program
    {
        static void Main(String[] args)
        {
            int m = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());
            int[][] grid = new int[m][];

            for (int i = 0; i < m; i++)
            {
                grid[i] = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            }

            int maxConnectedCells = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int[][] arr = flow(grid, i, j);
                    int count = Count(arr);

                    if (count > maxConnectedCells)
                        maxConnectedCells = count;
                }
            }

            Console.WriteLine(maxConnectedCells);
        }

        public static int Count(int[][] arr)
        {
            int m = arr.Length;
            int n = arr[0].Length;

            int count = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i][j] == 1)
                        count++;
                }
            }

            return count;
        }

        public static int[][] flow(int[][] open, int i, int j)
        {
            int m = open.Length;
            int n = open[0].Length;

            int[][] full = new int[m][];

            for (int k = 0; k < m; k++)
            {
                full[k] = new int[n];
            }

            flow(open, full, i, j);

            return full;
        }

        private static void flow(int[][] open, int[][] full, int i, int j)
        {
            int m = open.Length;
            int n = open[0].Length;

            if (i < 0 || i >= m) return;
            if (j < 0 || j >= n) return;
            if (open[i][j] == 0) return;
            if (full[i][j] == 1) return;

            full[i][j] = 1;

            flow(open, full, i + 1, j);
            flow(open, full, i, j + 1);
            flow(open, full, i, j - 1);
            flow(open, full, i - 1, j);

            flow(open, full, i + 1, j + 1);
            flow(open, full, i - 1, j - 1);
            flow(open, full, i - 1, j + 1);
            flow(open, full, i + 1, j - 1);
        }
    }
}
