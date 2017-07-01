using System;

class FormingAMagicSquare
{
    static void Main(String[] args)
    {
        int[][][] magicalSquares = { new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } },
                                     new int[][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } },
                                     new int[][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } },
                                     new int[][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } },
                                     new int[][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } },
                                     new int[][] { new int[] { 2, 7, 6 }, new int[] { 9, 5, 1 }, new int[] { 4, 3, 8 } },
                                     new int[][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } },
                                     new int[][] { new int[] { 6, 7, 2 }, new int[] { 1, 5, 9 }, new int[] { 8, 3, 4 } },
        };

        int[][] s = new int[3][];

        for (int i = 0; i < 3; i++)
        {
            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        }

        int minCount = int.MaxValue;

        for (int a = 0; a < magicalSquares.Length; a++)
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    count += Math.Abs(magicalSquares[a][i][j] - s[i][j]);
                }
            }

            if (count < minCount)
                minCount = count;
        }

        Console.WriteLine(minCount);
    }
}
