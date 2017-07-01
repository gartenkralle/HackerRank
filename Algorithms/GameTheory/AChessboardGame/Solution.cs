using System;

namespace AChessboardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int x = xy[0] - 1;
                int y = xy[1] - 1;

                if (((y % 4) <= 1) && ((x % 4) <= 1))
                    Console.WriteLine("Second");
                else
                    Console.WriteLine("First");
            }
        }
    }
}
