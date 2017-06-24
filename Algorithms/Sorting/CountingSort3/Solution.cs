using System;

namespace CountingSort3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int maxValue = 100;
            int[] counts = new int[maxValue];


            for (int i = 0; i < n; i++)
            {
                int x = Int32.Parse(Console.ReadLine().Split(' ')[0]);
                counts[x]++;
            }

            for (int i = 1; i < maxValue; i++)
                counts[i] += counts[i - 1];

            Console.WriteLine(String.Join(" ", counts));
        }
    }
}
