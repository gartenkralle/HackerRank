using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            LT[] lts = new LT[n];

            for (int i = 0; i < n; i++)
            {
                int[] lt = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                lts[i].L = lt[0];
                lts[i].T = lt[1];
            }

            int count = 0;

            lts = lts.OrderBy(x => x.T).ThenByDescending(x => x.L).ToArray();

            int index = 0;

            while((index < lts.Length) && (lts[index].T == 0))
            {
                count += lts[index].L;
                index++;
            }

            while ((index < lts.Length) && (k > 0))
            {
                count += lts[index].L;
                index++;
                k--;
            }

            while (index < lts.Length)
            {
                count -= lts[index].L;
                index++;
            }

            Console.WriteLine(count);
        }
    }

    struct LT
    {
        public int L { get; set; }
        public int T { get; set; }
    }
}
