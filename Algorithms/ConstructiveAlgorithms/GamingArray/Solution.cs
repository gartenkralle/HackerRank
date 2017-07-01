using System;

namespace GamingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int count = 0;
                int max = int.MinValue;

                for (int j = 0; j < n; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        count++;
                    }
                }

                if (count % 2 == 0)
                    Console.WriteLine("ANDY");
                else
                    Console.WriteLine("BOB");
            }
        }
    }
}
