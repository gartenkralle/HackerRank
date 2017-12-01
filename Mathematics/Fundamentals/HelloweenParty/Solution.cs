using System;

namespace HelloweenParty
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int K = int.Parse(Console.ReadLine());

                if (IsEven(K))
                {
                    Console.WriteLine(Math.Pow(K / 2, 2));
                }
                else
                {
                    Console.WriteLine((long)(K / 2) * ((K / 2) + 1));
                }
            }
        }

        static bool IsEven(int n)
        {
            return (n % 2) == 0;
        }
    }
}
