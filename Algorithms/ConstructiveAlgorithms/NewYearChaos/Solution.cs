using System;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                MinimumBribes(q);
            }
        }

        static void MinimumBribes(int[] q)
        {
            if (IsChaotic(q))
            {
                Console.WriteLine("Too chaotic");
            }
            else
            {
                int count = 0;

                int[] asc = CreateAscendingSeries(q.Length);

                for (int i = 0; i < asc.Length; i++)
                {
                    int tmpCount = 0;

                    for (int j = i; asc[j] != q[i]; j++)
                    {
                        tmpCount++;
                    }

                    count += tmpCount;

                    while (tmpCount > 0)
                    {
                        Swap(ref asc[i + (tmpCount - 1)], ref asc[i + tmpCount]);

                        tmpCount--;
                    }
                }

                Console.WriteLine(count);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;

            a = b;
            b = temp;
        }

        static bool IsChaotic(int[] q)
        {
            for (int i = 0; i < q.Length; i++)
            {
                if ((q[i] - (i + 1)) > 2)
                {
                    return true;
                }
            }

            return false;
        }

        static int[] CreateAscendingSeries(int length)
        {
            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = i + 1;
            }

            return arr;
        }
    }
}
