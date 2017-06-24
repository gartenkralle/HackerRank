using System;

namespace SumVsXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long residualCount = 0;

            while (n != 0)
            {
                if ((n % 2) == 0)
                    residualCount++;

                n /= 2;
            }

            long count = (long)Math.Pow(2, residualCount);

            Console.WriteLine(count);
        }
    }
}
