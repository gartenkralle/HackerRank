using System;
using System.Collections.Generic;
using System.Linq;

namespace StringsMakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> a = Console.ReadLine().ToList();
            List<char> b = Console.ReadLine().ToList();

            a.Sort();
            b.Sort();

            int i = 0;
            int j = 0;

            int count = 0;

            while((i < a.Count) && (j < b.Count))
            {
                if(a[i] < b[j])
                {
                    i++;
                    count++;
                }
                else if(b[j] < a[i])
                {
                    j++;
                    count++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            count = count + (a.Count - i) + (b.Count - j);

            Console.WriteLine(count);
        }
    }
}
