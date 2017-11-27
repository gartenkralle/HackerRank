using System;
using System.Collections.Generic;

namespace Gemstones
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] rocks = new string[N];

            for (int i = 0; i < N; i++)
            {
                rocks[i] = Console.ReadLine();
            }

            Console.WriteLine(GetGemstonesCount(rocks));
        }

        private static int GetGemstonesCount(string[] rocks)
        {
            HashSet<char> hashSet = new HashSet<char>(rocks[0]);
            int count = 0;

            foreach (char c in hashSet)
            {
                if (ContainsAll(rocks, c))
                {
                    count++;
                }
            }

            return count;
        }

        private static bool ContainsAll(string[] rocks, char c)
        {
            foreach (string s in rocks)
            {
                if (!s.Contains(c.ToString()))
                    return false;
            }

            return true;
        }
    }
}
