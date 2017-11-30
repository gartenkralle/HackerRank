using System;
using System.Collections.Generic;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(String[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!dictionary.ContainsKey(a[i]))
                    dictionary.Add(a[i], 0);

                dictionary[a[i]]++;
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (!dictionary.ContainsKey(b[i]))
                    dictionary.Add(b[i], 0);

                dictionary[b[i]]--;
            }

            int sum = 0;

            foreach (KeyValuePair<char, int> keyValuePair in dictionary)
            {
                sum += Math.Abs(keyValuePair.Value);
            }

            Console.WriteLine(sum);
        }
    }
}
