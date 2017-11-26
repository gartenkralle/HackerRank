using System;
using System.Collections.Generic;

namespace LarrysArray
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (IsFullySortable(a))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        private static bool IsFullySortable(int[] a)
        {
            int count = 0;

            for (int i = 0; i < (a.Length - 1); i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                        count++;
                }
            }

            return IsEven(count);
        }

        private static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }
    }
}
