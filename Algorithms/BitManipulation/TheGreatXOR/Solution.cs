using System;

namespace TheGreatXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                long x = long.Parse(Console.ReadLine());

                long log = (long)(Math.Log(x) / Math.Log(2)) + 1;
                long nextPow = (long)Math.Pow(2, log);
                long result = (nextPow - 1) - x;

                Console.WriteLine(result);
            }
        }
    }
}
