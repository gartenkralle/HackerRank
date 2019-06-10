using System;
using System.Collections.Generic;

namespace FrequencyQueries
{
    class Program
    {
        static readonly Dictionary<int, int> dictionary = new Dictionary<int, int>();
        static readonly int[] array = new int[1000000];

        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            List<int[]> queries = new List<int[]>(q);

            for (int i = 0; i < q; i++)
            {
                queries.Add(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            }

            List<int> result = FreqQuery(queries);

            Console.WriteLine(String.Join(Environment.NewLine, result));
        }

        static List<int> FreqQuery(List<int[]> queries)
        {
            List<int> result = new List<int>();

            foreach (int[] query in queries)
            {
                int command = query[0];
                int value = query[1];

                switch (command)
                {
                    case 1:
                        Add(value);
                        break;

                    case 2:
                        Remove(value);
                        break;

                    case 3:
                        result.Add(GetPrintFreqCheck(value));
                        break;
                }
            }

            return result;
        }

        private static void Add(int key)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, 1);
            }
            else
            {
                dictionary[key]++;
            }

            array[dictionary[key]]++;
            array[dictionary[key] - 1]--;
        }

        private static void Remove(int key)
        {
            if (dictionary.ContainsKey(key) && (dictionary[key] >= 1))
            {
                array[dictionary[key]]--;
                array[dictionary[key] - 1]++;

                dictionary[key]--;
            }
        }

        private static int GetPrintFreqCheck(int value)
        {
            if (value < 1000000)
            {
                if (array[value] >= 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            return 0;
        }
    }
}
