using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(days(n));
        }

        static int days(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += day(i);

            return sum;
        }

        static int day(int n)
        {
            if (n == 1)
                return 2;

            return (day(n - 1) * 3) / 2;
        }
    }
}
