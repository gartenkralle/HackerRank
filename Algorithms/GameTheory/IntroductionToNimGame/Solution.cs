using System;

namespace IntroductionToNimGame
{
    class Program
    {
        static void Main(String[] args)
        {
            int g = int.Parse(Console.ReadLine());

            for (int i = 0; i < g; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int result = 0;

                foreach (int a in s)
                {
                    result ^= a;
                }

                if (result == 0)
                {
                    Console.WriteLine("Second");
                }
                else
                {
                    Console.WriteLine("First");
                }
            }
        }
    }
}
