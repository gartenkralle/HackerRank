using System;

namespace Handshake
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine(((N * N) - N) / 2);
            }
        }
    }
}
