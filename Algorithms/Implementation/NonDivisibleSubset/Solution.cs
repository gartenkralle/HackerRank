using System;
using System.Collections.Generic;
using System.Linq;

namespace NonDivisibleSubset
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(GetNonDivisibleSubsetCount(arr, k));
        }

        private static int GetNonDivisibleSubsetCount(int[] arr, int k)
        {
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

            foreach (int a in arr)
            {
                int mod = a % k;

                if (dictionary.ContainsKey(mod))
                {
                    dictionary[mod].Add(a);
                }
                else
                {
                    dictionary.Add(mod, new List<int> { a });
                }
            }

            int count = 0;
            int[] keys = dictionary.Keys.ToArray();

            for (int i = 0; i < keys.Length; i++)
            {
                int key = keys[i];
                int negativeKey = (k - key) % k;
                int keyLength = dictionary[key].Count;

                if (dictionary.ContainsKey(negativeKey))
                {
                    int negativeKeyLength = dictionary[negativeKey].Count;

                    if (key == negativeKey)
                    {
                        count++;
                    }
                    else
                    {
                        if (keyLength > negativeKeyLength)
                        {
                            count += keyLength;
                        }
                    }
                }
                else
                {
                    count += keyLength;
                }
            }

            return count;
        }
    }
}
