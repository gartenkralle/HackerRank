using System;

namespace SherlockAndDivisors
{
    static class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());

                int sqrt = (int)Math.Sqrt(N);

                int count = 0;

                for (int j = 1; j <= sqrt; j++)
                {
                    if ((N % j) == 0)
                    {
                        if ((j % 2) == 0)
                            count++;
                        if ((j != (N / j)) && ((N / j) % 2) == 0)
                            count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
