using System;
using System.Numerics;

namespace IsFibo
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                BigInteger N = long.Parse(Console.ReadLine());

                if (IsFibo(N))
                    Console.WriteLine("IsFibo");
                else
                    Console.WriteLine("IsNotFibo");
            }
        }

        private static bool IsFibo(BigInteger number)
        {
            return IsSqrt((5 * number * number) + 4) || IsSqrt((5 * number * number) - 4);
        }

        private static Boolean IsSqrt(BigInteger n)
        {
            BigInteger root = Sqrt(n);

            return BigInteger.Pow(root, 2) == n;
        }

        public static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0)
                return 0;

            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!IsSqrt(n, root))
                {
                    root += (n / root);
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean IsSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return ((n >= lowerBound) && (n < upperBound));
        }
    }
}
