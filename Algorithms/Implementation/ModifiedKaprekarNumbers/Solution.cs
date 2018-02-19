using System;
using System.Collections.Generic;
using System.Linq;

namespace ModifiedKaprekarNumbers
{
    class Program
    {
        static void Main(String[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            int[] result = KaprekarNumbers(p, q);

            if (result.Length != 0)
                Console.WriteLine(String.Join(" ", result));
            else
                Console.WriteLine("INVALID RANGE");
        }

        static int[] KaprekarNumbers(int p, int q)
        {
            List<int> result = new List<int>();

            while (p <= q)
            {
                if (IsKaprekarNumber(p))
                    result.Add(p);

                p++;
            }

            return result.ToArray();
        }

        private static bool IsKaprekarNumber(int number)
        {
            if (number == 1)
                return true;

            long square = (long)number * number;

            if (square.ToString().Length == 1)
                return false;

            int d = square.ToString().Length / 2;
            int[] lr = Split(square, d);

            if ((lr[1] != 0) && (lr.Sum() == number))
                return true;

            return false;
        }

        private static int[] Split(long number, int index)
        {
            return new int[] { int.Parse(number.ToString().Substring(0, index)), int.Parse(number.ToString().Substring(index)) };
        }
    }
}
