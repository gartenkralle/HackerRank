using System;
using System.Collections.Generic;

namespace KnightLOnAChessboard
{
    class Program
    {
        static int defaultValue = -1;

        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = GetChessboardMovesCount(n);

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        private static int[][] GetChessboardMovesCount(int n)
        {
            int[][] matrix = GetMatrix(n - 1);

            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[i][j] = BreathFirstSearch(n, (i + 1), (j + 1));
                    matrix[j][i] = matrix[i][j];
                }
            }

            return matrix;
        }

        private static int BreathFirstSearch(int n, int i, int j)
        {
            int[][] matrix = GetMatrix(n, defaultValue);

            Queue<Position> unvisitedPositions = new Queue<Position>();
            unvisitedPositions.Enqueue(new Position(0, 0, 0));

            while ((matrix[n - 1][n - 1] == defaultValue) && (unvisitedPositions.Count != 0))
            {
                Position currentPosition = unvisitedPositions.Dequeue();
                matrix[currentPosition.Y][currentPosition.X] = currentPosition.MoveCount;

                Enqueue(unvisitedPositions, GetUnvisitedNeightbourPositions(matrix, currentPosition, i, j, (currentPosition.MoveCount + 1)));
            }

            return matrix[n - 1][n - 1];
        }

        private static void Enqueue(Queue<Position> unvisitedPositions, List<Position> list)
        {
            foreach (Position position in list)
            {
                if (!unvisitedPositions.Contains(position))
                    unvisitedPositions.Enqueue(position);
            }
        }

        private static List<Position> GetUnvisitedNeightbourPositions(int[][] matrix, Position currentPosition, int i, int j, int moveCount)
        {
            List<Position> positions = new List<Position>();

            TryAddPosition(positions, matrix, (currentPosition.X + i), (currentPosition.Y + j), moveCount);
            TryAddPosition(positions, matrix, (currentPosition.X - i), (currentPosition.Y + j), moveCount);
            TryAddPosition(positions, matrix, (currentPosition.X + i), (currentPosition.Y - j), moveCount);
            TryAddPosition(positions, matrix, (currentPosition.X - i), (currentPosition.Y - j), moveCount);

            if (i != j)
            {
                TryAddPosition(positions, matrix, (currentPosition.X + j), (currentPosition.Y + i), moveCount);
                TryAddPosition(positions, matrix, (currentPosition.X - j), (currentPosition.Y + i), moveCount);
                TryAddPosition(positions, matrix, (currentPosition.X + j), (currentPosition.Y - i), moveCount);
                TryAddPosition(positions, matrix, (currentPosition.X - j), (currentPosition.Y - i), moveCount);
            }

            return positions;
        }

        private static void TryAddPosition(List<Position> positions, int[][] matrix, int x, int y, int moveCount)
        {
            int n = matrix.Length;

            if (IsInside(x, y, n) && matrix[y][x] == defaultValue)
            {
                positions.Add(new Position(y, x, moveCount));
            }
        }

        private static bool IsInside(int x, int y, int n)
        {
            return (x >= 0) && (y >= 0) && (x < n) && (y < n);
        }

        private static int[][] GetMatrix(int size, int defaultValue)
        {
            int[][] matrix = GetMatrix(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i][j] = defaultValue;
                }
            }

            return matrix;
        }

        private static int[][] GetMatrix(int size)
        {
            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = new int[size];
            }

            return matrix;
        }
    }

    struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int MoveCount { get; set; }

        public Position(int x, int y, int moveCount)
        {
            X = x;
            Y = y;

            MoveCount = moveCount;
        }
    }
}
