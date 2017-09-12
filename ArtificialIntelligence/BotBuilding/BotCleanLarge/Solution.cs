using System;

namespace BotCleanLarge
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] pos = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] dim = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            String[] board = new String[dim[0]];

            for (int i = 0; i < dim[0]; i++)
            {
                board[i] = Console.ReadLine();
            }

            next_move(pos[0], pos[1], dim[0], dim[1], board);
        }

        static void next_move(int posr, int posc, int dimr, int dimc, String[] board)
        {
            if (board[posr][posc] == 'd')
            {
                Console.WriteLine("CLEAN");
                return;
            }

            int[] position = getNextDiryCellPosition(board, posr, dimr, dimc, posc);

            if (position[1] > posc)
            {
                Console.WriteLine("RIGHT");
            }
            else if (position[1] < posc)
            {
                Console.WriteLine("LEFT");
            }
            else if (position[0] > posr)
            {
                Console.WriteLine("DOWN");
            }
            else if (position[0] < posr)
            {
                Console.WriteLine("UP");
            }
        }

        private static int[] getNextDiryCellPosition(string[] board, int posr, int dimr, int dimc, int posc)
        {
            int[] position = new int[2];
            int minDistance = Int32.MaxValue;

            for (int i = 0; i < dimr; i++)
            {
                for (int j = 0; j < dimc; j++)
                {
                    int distance = (Math.Abs(i - posr) + Math.Abs(j - posc));

                    if ((board[i][j] == 'd') && (distance < minDistance))
                    {
                        position[0] = i;
                        position[1] = j;

                        minDistance = distance;
                    }
                }
            }

            return position;
        }
    }
}
