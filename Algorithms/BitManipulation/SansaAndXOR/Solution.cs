using System;

namespace SansaAndXOR
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (IsEven(N))
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int result = array[0];

                    for (int j = 2; j < N; j += 2)
                    {
                        result ^= array[j];
                    }

                    Console.WriteLine(result);
                }
            }
        }

        private static bool IsEven(int n)
        {
            return (n % 2) == 0;
        }
    }
}
