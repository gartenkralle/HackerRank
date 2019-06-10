using System;
using System.Collections.Generic;

namespace TwoStrings
{
    class Program
    {
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

                Console.WriteLine(TwoStrings(s1, s2));
            }
        }

        static string TwoStrings(string s1, string s2)
        {
            HashSet<char> hashSet = new HashSet<char>();

            foreach(char c in s1)
            {
                hashSet.Add(c);
            }

            foreach(char c in s2)
            {
                if (hashSet.Contains(c))
                    return "YES";
            }

            return "NO";
        }
    }
}
