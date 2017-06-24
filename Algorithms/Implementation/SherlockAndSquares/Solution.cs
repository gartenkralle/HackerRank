using System;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int A = Int32.Parse(s[0]);
                int B = Int32.Parse(s[1]);

                int sqrtA = (int)Math.Sqrt(A-1);
                int sqrtB = (int)(Math.Sqrt(B));

                int res = sqrtB - sqrtA;

                Console.WriteLine(res);
            }
        }
    }
}
