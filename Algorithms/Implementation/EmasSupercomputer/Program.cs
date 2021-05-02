using System;

namespace EmasSupercomputer
{
    class Program
    {
        static void Main()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            _ = Convert.ToInt32(nm[1]);

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            int result = TwoPluses(grid);

            Console.WriteLine(result);
        }

        static int TwoPluses(string[] grid)
        {
            return GetMaximumProduct(grid);
        }

        private static int GetMaximumProduct(string[] grid)
        {
            int maximumProduct = 0;

            char[,] currentGrid = new char[grid.Length, grid[0].Length];
            CopyTo(grid, currentGrid);

            for (int i = 1; i <= grid.Length; i += 2)
            {
                for (int j = i; j <= grid.Length; j += 2)
                {
                    if (CheckForCrossPair(currentGrid, i, j))
                    {
                        int currentProduct = (2 * i - 1) * (2 * j - 1);

                        if (currentProduct > maximumProduct)
                        {
                            maximumProduct = currentProduct;
                        }
                    }
                }
            }

            return maximumProduct;
        }

        private static bool CheckForCrossPair(char[,] grid, int size1, int size2)
        {
            int startIndex1 = (size1 - 1) / 2;
            int startIndex2 = (size2 - 1) / 2;

            for (int i = startIndex1; i < grid.GetLength(0) - startIndex1; i++)
            {
                for (int j = startIndex1; j < grid.GetLength(1) - startIndex1; j++)
                {
                    for (int k = startIndex2; k < grid.GetLength(0) - startIndex2; k++)
                    {
                        for (int l = startIndex2; l < grid.GetLength(1) - startIndex2; l++)
                        {
                            RestoreGrid(grid);

                            if (CheckForCross(grid, size1, i, j) && CheckForCross(grid, size2, k, l))
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private static bool CheckForCross(char[,] grid, int size, int i, int j)
        {
            if (HasCross(grid, i, j, size))
            {
                MarkCross(grid, i, j, size);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool HasCross(char[,] grid, int row, int col, int size)
        {
            int steps = (size - 1) / 2;

            if (grid[row, col] != 'G')
            {
                return false;
            }

            for (int i = 1; i <= steps; i++)
            {
                if (grid[row, col + i] != 'G' ||
                    grid[row, col - i] != 'G' ||
                    grid[row + i, col] != 'G' ||
                    grid[row - i, col] != 'G')
                {
                    return false;
                }
            }

            return true;
        }

        private static void MarkCross(char[,] grid, int row, int col, int size)
        {
            int steps = (size - 1) / 2;

            grid[row, col] = 'X';

            for (int i = 1; i <= steps; i++)
            {
                grid[row, col + i] = 'X';
                grid[row, col - i] = 'X';
                grid[row + i, col] = 'X';
                grid[row - i, col] = 'X';
            }
        }

        private static void RestoreGrid(char[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 'X')
                    {
                        grid[i, j] = 'G';
                    }
                }
            }
        }

        private static void CopyTo(string[] grid, char[,] currentGrid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                char[] line = grid[i].ToCharArray();

                for (int j = 0; j < line.Length; j++)
                {
                    currentGrid[i, j] = line[j];
                }
            }
        }
    }
}
