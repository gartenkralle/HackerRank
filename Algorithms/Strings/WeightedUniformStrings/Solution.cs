using System;
using System.Collections.Generic;

namespace WeightedUniformStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            HashSet<int> weights = new HashSet<int>();

            int count = 0;
            int lastChar = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (lastChar == s[i])
                    count++;
                else
                    count = 1;

                weights.Add(count * Value(s[i]));
                
                lastChar = s[i];
            }

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                string result;

                if (weights.Contains(x))
                    result = "Yes";
                else
                    result = "No";

                Console.WriteLine(result);
            }
        }

        static int Value(char c)
        {
            return Convert.ToInt32(c) - (97 - 1);
        }
    }
}
