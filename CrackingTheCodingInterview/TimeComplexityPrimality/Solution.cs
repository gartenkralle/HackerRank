using System;

namespace TimeComplexityPrimality
{
    class Program
    {
        static void Main(String[] args)
        {
            int p = int.Parse(Console.ReadLine());

            for (int i = 0; i < p; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (IsPrime(n))
                    Console.WriteLine("Prime");
                else
                    Console.WriteLine("Not prime");
            }
        }

        static bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }

            int root = (int)Math.Sqrt(n);

            for (int i = 2; i <= root; i++)
            {
                if ((n % i) == 0)
                    return false;
            }

            return true;
        }
    }
}
