using System;

namespace ArmyGame
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nm[0];
            int m = nm[1];

            int n4 = n / 2;
            int m4 = m / 2;

            int count = n4 * m4;

            if ((n % 2) == 1)
                count += (m / 2);

            if ((m % 2) == 1)
                count += (n / 2);

            if (((n % 2) == 1) && ((m % 2) == 1))
                count++;

            Console.WriteLine(count);
        }
    }
}
