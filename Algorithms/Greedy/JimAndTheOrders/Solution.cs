using System;
using System.Collections.Generic;
using System.Linq;

namespace JimAndTheOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int[] t = new int[n];
            int[] d = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] td = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

                t[i] = td[0];
                d[i] = td[1];
            }

            List<int> list = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(t[i] + d[i]);
                dict[i + 1] = t[i] + d[i];
            }

            list.Sort();

            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                res[i] = dict.FirstOrDefault(x => x.Value == list[i]).Key;
                dict.Remove(res[i]);
            }

            Console.WriteLine(String.Join(" ", res));
        }
    }
}
