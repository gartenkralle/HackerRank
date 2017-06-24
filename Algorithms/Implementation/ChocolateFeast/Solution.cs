using System;
using System.Collections.Generic;
using System.Linq;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] NCM = Console.ReadLine().Split(' ');
                int N = Int32.Parse(NCM[0]);
                int C = Int32.Parse(NCM[1]);
                int M = Int32.Parse(NCM[2]);

                int amount = N / C;

                List<int> additionals = new List<int>();
                int additional = amount / M;
                int rest = amount % M;
                additionals.Add(additional);

                while (additional != 0)
                {
                    int tmp = additional;
                    additional = (rest + additional) / M;
                    rest = (rest + tmp) % M;
                    additionals.Add(additional);
                }

                Console.WriteLine(amount + additionals.Sum());
            }
        }
    }
}
