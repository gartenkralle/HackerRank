using System;

namespace CounterGame
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                long N = long.Parse(Console.ReadLine());

                if (IsEven(GetMovesCount(N)))
                {
                    Console.WriteLine("Richard");
                }
                else
                {
                    Console.WriteLine("Louise");
                }
            }
        }

        private static long GetMovesCount(long number)
        {
            int count = 0;

            while (number != 1)
            {
                if (IsPowerOfTwo(number))
                {
                    number >>= 1;
                    count++;
                }
                else
                {
                    number -= (long)Math.Pow(2, (int)(Math.Log(number) / Math.Log(2)));
                    count++;
                }
            }

            return count;
        }

        private static bool IsPowerOfTwo(long number)
        {
            return (number & (number - 1)) == 0;
        }

        private static bool IsEven(long number)
        {
            return (number % 2) == 0;
        }
    }
}
