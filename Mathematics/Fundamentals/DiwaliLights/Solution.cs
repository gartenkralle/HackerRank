using System;

namespace DiwaliLights
{
    static class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());

                int basis = 1;

                for (int j = 0; j < N; j++)
                {
                    basis = (2 * basis) % 100000;
                }

                int result = basis - 1;

                Console.WriteLine(result);
            }
        }
    }
}
