using System;

namespace BirthdayChocolate
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] dm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int d = dm[0];
            int m = dm[1];

            int count = 0;

            for (int i = 0; (i + (m - 1)) < n; i++)
            {
                int sum = 0;

                for (int j = 0; j < m; j++)
                {
                    sum += s[i + j];
                }

                if (sum == d)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
