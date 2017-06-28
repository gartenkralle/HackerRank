using System;

namespace Restaurant
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] lb = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int l = lb[0];
                int b = lb[1];

                int area = l * b;
                int side = Gcd(l, b);
                int count = area / (side * side);

                Console.WriteLine(count);
            }
        }

        static int Gcd(int a, int b)
        {
            if (a == b)
                return a;
            else if (a > b)
                return Gcd(a - b, b);
            else
                return Gcd(a, b - a);
        }
    }
}
