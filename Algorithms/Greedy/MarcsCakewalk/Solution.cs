using System;

namespace MarcsCakewald
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            long minimumMiles = 0;

            Array.Sort(c);

            for (int i = (n - 1); i >= 0; i--)
                minimumMiles += (c[i] * (long)Math.Pow(2, n - (i + 1)));

            Console.WriteLine(minimumMiles);
        }
    }
}
