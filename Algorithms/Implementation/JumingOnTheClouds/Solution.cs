using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int count = n - 1;

            for (int i = 0; i < (n - 2); i++)
            {
                if (a[i + 2] == 0)
                {
                    i++;
                    count--;
                }
            }

            Console.WriteLine(count);
        }
    }
}
