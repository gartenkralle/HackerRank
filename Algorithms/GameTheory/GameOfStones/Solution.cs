using System;

namespace GameOfStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 7 <= 1)
                    Console.WriteLine("Second");
                else
                    Console.WriteLine("First");
            }
        }
    }
}
