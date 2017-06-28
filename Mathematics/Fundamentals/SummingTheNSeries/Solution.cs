using System;
using System.Numerics;

namespace SummingTheNSeries
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                BigInteger n = BigInteger.Parse(Console.ReadLine());

                string result = (BigInteger.Multiply(n, n) % (BigInteger)(Math.Pow(10, 9) + 7)).ToString();

                Console.WriteLine(result);
            }
        }
    }
}
