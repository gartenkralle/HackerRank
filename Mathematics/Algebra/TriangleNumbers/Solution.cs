using System;

namespace TriangleNumbers
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if (!IsEven(N))
                {
                    Console.WriteLine(2);
                }
                else if ((N % 4) == 0)
                {
                    Console.WriteLine(3);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
        }

        static bool IsEven(int n)
        {
            return (n % 2) == 0;
        }
    }
}
