using System;

namespace JumpingOnTheCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int n = nk[0];
            int k = nk[1];

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int e = 100;

            int i = 0;

            do
            {
                i += k;

                if (c[i % n] == 0)
                    e -= 1;
                else
                    e -= 3;
            }
            while ((i % n) != 0);

            Console.WriteLine(e);
        }
    }
}
