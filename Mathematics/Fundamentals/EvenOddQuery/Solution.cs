using System;

namespace EvenOddQuery
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int Q = int.Parse(Console.ReadLine());

            for (int i = 0; i < Q; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int x = xy[0] - 1;
                int y = xy[1] - 1;

                Console.WriteLine(GetIsEvenAsText(IsEven(Find(A, x, y))));
            }
        }

        static string GetIsEvenAsText(bool even)
        {
            return even ? "Even" : "Odd";
        }

        static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }

        static int Find(int[] A, int x, int y)
        {
            if ((x < y) && ((x + 1) < A.Length) && (A[x + 1] == 0))
                return 1;
            else
                return A[x];
        }
    }
}
