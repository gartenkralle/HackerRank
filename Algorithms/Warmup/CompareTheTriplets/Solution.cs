using System;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int aCount = 0;
            int bCount = 0;

            compare(a0, b0, ref aCount, ref bCount);
            compare(a1, b1, ref aCount, ref bCount);
            compare(a2, b2, ref aCount, ref bCount);

            Console.WriteLine(aCount + " " + bCount);
        }

        private static void compare(int a, int b, ref int aCount, ref int bCount)
        {
            if (a > b)
                aCount++;
            else if (b > a)
                bCount++;
        }
    }
}
