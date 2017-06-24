using System;

namespace CountLuck
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] MN = Console.ReadLine().Split(' ');
                int M = Int32.Parse(MN[0]);
                int N = Int32.Parse(MN[1]);

                char[][] grid = new char[M][];

                for (int row = 0; row < M; row++)
                {
                    grid[row] = Console.ReadLine().ToCharArray();
                }

                int K = Int32.Parse(Console.ReadLine());

                int startRow, startColumn;

                Search(grid, 'M', out startRow, out startColumn);

                int decisionCount;

                flow(grid, startRow, startColumn, out decisionCount);

                if (decisionCount == K)
                    Console.WriteLine("Impressed");
                else
                    Console.WriteLine("Oops!");
            }
        }

        public static void Search(char[][] grid, char c, out int row, out int column)
        {
            row = -1;
            column = -1;

            int M = grid.Length;
            int N = grid[0].Length;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (grid[i][j] == c)
                    {
                        row = i;
                        column = j;
                    }
                }
            }
        }

        private static void flow(char[][] open, int i, int j, out int res)
        {
            int m = open.Length;
            int n = open[0].Length;

            res = -1;

            char[][] full = new char[m][];

            for (int k = 0; k < m; k++)
            {
                full[k] = new char[n];
            }

            flow(open, full, i, j, ref res, 0);
        }

        private static void flow(char[][] open, char[][] full, int i, int j, ref int res, int decisions)
        {
            if (!isValid(open, full, i, j))
                return;

            if (open[i][j] == '*')
            {
                res = decisions;
                return;
            }

            if (multiplePossibilities(open, full, i, j))
                decisions++;

            full[i][j] = 'X';

            if (!isFound(res))
                flow(open, full, i, j + 1, ref res, decisions);
            if (!isFound(res))
                flow(open, full, i - 1, j, ref res, decisions);
            if (!isFound(res))
                flow(open, full, i, j - 1, ref res, decisions);
            if (!isFound(res))
                flow(open, full, i + 1, j, ref res, decisions);
        }

        private static bool isFound(int res)
        {
            return res != -1;
        }

        private static bool isValid(char[][] open, char[][] full, int i, int j)
        {
            return (isOpen(open, i, j) && isOpen(full, i, j));
        }

        private static bool multiplePossibilities(char[][] open, char[][] full, int i, int j)
        {
            int validDirectionCount = 0;

            validDirectionCount += isValid(open, full, i, j + 1) ? 1 : 0;
            validDirectionCount += isValid(open, full, i - 1, j) ? 1 : 0;
            validDirectionCount += isValid(open, full, i, j - 1) ? 1 : 0;
            validDirectionCount += isValid(open, full, i + 1, j) ? 1 : 0;

            return validDirectionCount > 1;
        }

        private static bool isOpen(char[][] grid, int i, int j)
        {
            int M = grid.Length;
            int N = grid[0].Length;

            if (i < 0 || i >= M) return false;
            if (j < 0 || j >= N) return false;
            if (grid[i][j] == 'X') return false;

            return true;
        }
    }
}
