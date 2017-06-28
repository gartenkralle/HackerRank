using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(N));
        }

        static BigInteger Factorial(BigInteger number)
        {
            if (number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
