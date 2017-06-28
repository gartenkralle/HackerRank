using System;
using System.Collections.Generic;

namespace BigSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String[] integers = new String[n];

            for (int i = 0; i < n; i++)
            {
                integers[i] = Console.ReadLine();
            }

            Array.Sort(integers, new StringComparer());

            foreach (String integer in integers)
                Console.WriteLine(integer);
        }
    }

    class StringComparer : IComparer<String>
    {
        public int Compare(String s1, String s2)
        {
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                        return s1[i].CompareTo(s2[i]);
                }

                return 0;
            }
            else
            {
                return s1.Length.CompareTo(s2.Length);
            }
        }
    }
}
