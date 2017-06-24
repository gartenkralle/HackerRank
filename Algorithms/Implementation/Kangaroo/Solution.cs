using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int x1 = input[0];
            int v1 = input[1];
            int x2 = input[2];
            int v2 = input[3];

            string result;

            bool satisfied;

            if (v1 == v2)
            {
                if (x1 == x2)
                    result = "YES";
                else
                    result = "NO";
            }
            else
            {
                int i = Math.Abs((x2 - x1) / (v1 - v2));
                satisfied = x1 + (i * v1) == x2 + (i * v2);

                if (satisfied)
                    result = "YES";
                else
                    result = "NO";
            }

            Console.WriteLine(result);
        }
    }
}
