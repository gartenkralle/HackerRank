using System;

namespace StrangeGridAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rc = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int r = rc[0];
            int c = rc[1];

            if (r % 2 == 1)
                Console.WriteLine((((long)r - 1) * 5) + ((c - 1) * 2));
            else
                Console.WriteLine((((long)r - 2) * 5) + ((c * 2) - 1));
        }
    }
}
