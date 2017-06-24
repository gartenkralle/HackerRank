using System;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int b = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
                if (i != k)
                    sum += c[i];

            sum /= 2;

            if (b > sum)
                Console.WriteLine(b - sum);
            else
                Console.WriteLine("Bon Appetit");
        }
    }
}
