using System;

namespace PythagoreanTripe
{
    class Program
    {
        static void Main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            long[] triple = PythagoreanTriple(a);
            Console.WriteLine(String.Join(" ", triple));
        }

        private static long[] PythagoreanTriple(int a)
        {
            long[] result = new long[3];

            int u = 1;
            int v = 1;

            if (!IsEven(a))
            {
                u = (a + 1) / 2;
                v = u - 1;
            }
            else
            {
                u = a / 2;
                v = 1;
            }

            result[0] = ((long)u * u) - ((long)v * v);
            result[1] = (long)2 * u * v;
            result[2] = ((long)u * u) + ((long)v * v);

            return result;
        }

        private static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }
    }
}
