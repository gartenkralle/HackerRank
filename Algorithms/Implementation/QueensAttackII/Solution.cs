using System;
using System.Collections.Generic;

namespace QueensAttackII
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] queensPosition = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Position queenPosition = new Position(queensPosition[1], queensPosition[0]);

            int[][] obstacles = new int[k][];

            for (int i = 0; i < k; i++)
            {
                obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            HashSet<Position> obstacleHashSet = new HashSet<Position>();

            for (int i = 0; i < k; i++)
            {
                obstacleHashSet.Add(new Position(obstacles[i][1], obstacles[i][0]));
            }

            int count =
                FreeCount(obstacleHashSet, n, queenPosition, Direction.Left) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.Right) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.Top) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.Buttom) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.TopLeft) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.TopRight) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.ButtomLeft) +
                FreeCount(obstacleHashSet, n, queenPosition, Direction.ButtomRight);

            Console.WriteLine(count);
        }

        private static int FreeCount(HashSet<Position> obstacleHashSet, int n, Position queenPosition, Direction direction)
        {
            int count = 0;

            switch (direction)
            {
                case Direction.Left:
                    count = FreeCount(obstacleHashSet, n, queenPosition, -1, 0);
                    break;

                case Direction.Right:
                    count = FreeCount(obstacleHashSet, n, queenPosition, 1, 0);
                    break;

                case Direction.Top:
                    count = FreeCount(obstacleHashSet, n, queenPosition, 0, 1);
                    break;

                case Direction.Buttom:
                    count = FreeCount(obstacleHashSet, n, queenPosition, 0, -1);
                    break;

                case Direction.TopLeft:
                    count = FreeCount(obstacleHashSet, n, queenPosition, -1, 1);
                    break;

                case Direction.TopRight:
                    count = FreeCount(obstacleHashSet, n, queenPosition, 1, 1);
                    break;

                case Direction.ButtomLeft:
                    count = FreeCount(obstacleHashSet, n, queenPosition, -1, -1);
                    break;

                case Direction.ButtomRight:
                    count = FreeCount(obstacleHashSet, n, queenPosition, 1, -1);
                    break;
            }

            return count;
        }

        private static int FreeCount(HashSet<Position> obstacleHashSet, int n, Position queenPosition, int x, int y)
        {
            int count = 0;

            for (int i = 1; i < n; i++)
            {
                queenPosition.X += x;
                queenPosition.Y += y;

                if (IsInside(queenPosition, n) && !obstacleHashSet.Contains(queenPosition))
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        private static bool IsInside(Position position, int n)
        {
            return (position.X >= 1) && (position.X <= n) && (position.Y >= 1) && (position.Y <= n);
        }
    }

    public struct Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public enum Direction
    {
        Left, Right, Top, Buttom, TopLeft, TopRight, ButtomLeft, ButtomRight
    }
}
