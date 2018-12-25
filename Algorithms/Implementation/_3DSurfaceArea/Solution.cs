using System;

namespace _3DSurfaceArea
{
    static class Program
    {
        static void Main(String[] args)
        {
            string[] HW = Console.ReadLine().Split(' ');
            int H = Convert.ToInt32(HW[0]);
            int W = Convert.ToInt32(HW[1]);
            int[][] matrix = new int[H][];

            for (int i = 0; i < H; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                matrix[i] = Array.ConvertAll(row, Int32.Parse);
            }

            int result = SurfaceArea(matrix);
            Console.WriteLine(result);
        }

        static int SurfaceArea(int[][] matrix)
        {
            int count = 2 * (matrix.Length * matrix[0].Length);

            matrix = GetBoundaryMatrix(matrix);

            count += GetHorizontalAreas(matrix);
            count += GetVerticalAreas(matrix);

            return count;
        }

        private static int GetHorizontalAreas(int[][] matrix)
        {
            int count = 0;

            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            for (int i = 1; i < (rowCount - 1); i++)
            {
                for (int j = 0; j < (colCount - 1); j++)
                {
                    int leftRightDiff = matrix[i][j + 1] - matrix[i][j];

                    if (leftRightDiff > 0)
                        count += leftRightDiff;

                    int rightLeftDiff = matrix[i][(colCount - 1) - (j + 1)] - matrix[i][(colCount - 1) - j];

                    if (rightLeftDiff > 0)
                        count += rightLeftDiff;
                }
            }

            return count;
        }

        private static int GetVerticalAreas(int[][] matrix)
        {
            int count = 0;

            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            for (int i = 0; i < (rowCount - 1); i++)
            {
                for (int j = 1; j < (colCount - 1); j++)
                {
                    int topDownDiff = matrix[i + 1][j] - matrix[i][j];

                    if (topDownDiff > 0)
                        count += topDownDiff;

                    int buttomUpDiff = matrix[(rowCount - 1) - (i + 1)][j] - matrix[(rowCount - 1) - i][j];

                    if (buttomUpDiff > 0)
                        count += buttomUpDiff;
                }
            }

            return count;
        }

        private static int[][] GetBoundaryMatrix(int[][] matrix)
        {
            int rowCount = matrix.Length;
            int colCount = matrix[0].Length;

            int[][] boundaryMatrix = new int[rowCount + 2][];

            for (int i = 0; i < boundaryMatrix.Length; i++)
            {
                boundaryMatrix[i] = new int[colCount + 2];
            }

            for (int i = 1; i < (boundaryMatrix.Length - 1); i++)
            {
                for (int j = 1; j < (boundaryMatrix[i].Length - 1); j++)
                {
                    boundaryMatrix[i][j] = matrix[i - 1][j - 1];
                }
            }

            return boundaryMatrix;
        }
    }
}
