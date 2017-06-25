using System;
using System.Collections.Generic;

namespace RegExPatternsAndIntroToDatabases
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            string[] data = new string[T];

            for (int i = 0; i < T; i++)
            {
                data[i] = Console.ReadLine();
            }

            List<string> results = GetName(data, "@gmail.com");

            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }

        private static List<string> GetName(string[] data, string pattern)
        {
            List<string> results = new List<string>();

            foreach (string entry in data)
            {
                if (entry.Contains(pattern))
                {
                    results.Add(entry.Split(' ')[0]);
                }
            }

            results.Sort();

            return results;
        }
    }
}
