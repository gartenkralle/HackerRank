using System;

namespace MaximumDraws
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(n + 1);
            }
        }
    }
}
