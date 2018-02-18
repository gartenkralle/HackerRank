using System;

namespace CavityMap
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            grid = CavityMap(grid);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(grid[i]);
            }
        }

        static string[] CavityMap(string[] grid)
        {
            string[] result = Copy(grid);

            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int j = 1; j < grid.Length - 1; j++)
                {
                    if (IsCavity(grid, i, j))
                        result[i] = result[i].Substring(0, j) + 'X' + result[i].Substring(j + 1);
                }
            }

            return result;
        }

        private static bool IsCavity(string[] grid, int i, int j)
        {
            return IsGreater(grid[i][j], grid[i][j + 1]) && IsGreater(grid[i][j], grid[i + 1][j]) && IsGreater(grid[i][j], grid[i][j - 1]) && IsGreater(grid[i][j], grid[i - 1][j]);
        }

        private static bool IsGreater(char reference, char adjacence)
        {
            return int.Parse(reference.ToString()) > int.Parse(adjacence.ToString());
        }

        private static string[] Copy(string[] grid)
        {
            string[] result = new string[grid.Length];

            for (int i = 0; i < grid.Length; i++)
            {
                result[i] = grid[i];
            }

            return result;
        }
    }
}
