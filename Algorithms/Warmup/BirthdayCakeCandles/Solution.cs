using System;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int maxHeight = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (height[i] >= maxHeight)
                {
                    maxHeight = height[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (height[i] == maxHeight)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
