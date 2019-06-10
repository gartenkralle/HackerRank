using System;
using System.Collections.Generic;
using System.Linq;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            List<int> c = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();
            c.Sort();

            int count = 0;

            for (int i = 0; i < (c.Count - 1); i++)
            {
                for (int j = (i + 1); j < c.Count; j++)
                {
                    if (c[i] == c[j])
                    {
                        c.RemoveAt(i);
                        c.RemoveAt(i);

                        count++;

                        j--;
                    }
                    else
                        break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
