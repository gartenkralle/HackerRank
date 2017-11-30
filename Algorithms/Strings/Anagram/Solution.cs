using System;
using System.Collections.Generic;

namespace Anagram
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();

                if (!IsEven(s.Length))
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    string a = s.Substring(0, s.Length / 2);
                    string b = s.Substring(s.Length / 2, s.Length / 2);

                    Dictionary<char, int> dictionary = new Dictionary<char, int>();

                    for (int j = 0; j < a.Length; j++)
                    {
                        if (!dictionary.ContainsKey(a[j]))
                            dictionary.Add(a[j], 0);

                        dictionary[a[j]]++;
                    }

                    for (int j = 0; j < b.Length; j++)
                    {
                        if (!dictionary.ContainsKey(b[j]))
                            dictionary.Add(b[j], 0);

                        dictionary[b[j]]--;
                    }

                    int sum = 0;

                    foreach (KeyValuePair<char, int> keyValuePair in dictionary)
                    {
                        sum += Math.Abs(keyValuePair.Value);
                    }

                    Console.WriteLine(sum / 2);
                }
            }
        }

        private static bool IsEven(int n)
        {
            return (n % 2) == 0;
        }
    }
}
