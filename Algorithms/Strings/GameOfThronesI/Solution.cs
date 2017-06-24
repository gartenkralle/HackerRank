using System;
using System.Collections.Generic;

namespace GameOfThronesI
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Dictionary<char, bool> dict = new Dictionary<char, bool>();

            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                    dict[c] = false;
                else
                    dict[c] = !dict[c];
            }

            int odd = 0;

            foreach (KeyValuePair<char, bool> kv in dict)
            {
                if (!kv.Value)
                    odd++;
            }

            if (odd > 1)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
