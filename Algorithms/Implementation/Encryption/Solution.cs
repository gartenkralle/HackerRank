using System;
using System.Collections.Generic;

namespace Encryption
{
    class Program
    {
        static void Main(String[] args)
        {
            string text = Console.ReadLine();
            int L = text.Length;

            int sqrt = (int)Math.Sqrt(L);

            int row = sqrt;
            int col = sqrt;

            if (row * col < L)
                col++;
            if (row * col < L)
                row++;

            char[,] grid = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (((i * col) + j) >= L)
                        break;

                    grid[i, j] = text[(i * col) + j];
                }
            }

            List<string> result = new List<string>();

            for (int i = 0; i < col; i++)
            {
                List<char> chars = new List<char>();

                for (int j = 0; j < row; j++)
                {
                    if (!Char.IsLetter(grid[j, i]))
                        continue;

                    chars.Add(grid[j, i]);
                }

                result.Add(String.Join("", chars));
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
