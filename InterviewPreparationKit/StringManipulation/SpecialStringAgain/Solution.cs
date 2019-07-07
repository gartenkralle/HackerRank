using System;
using System.Collections.Generic;

namespace SpecialStringAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = SubstrCount(n, s);

            Console.WriteLine(result);
        }

        static long SubstrCount(int n, string s)
        {
            long count = 0;

            int[] frequencies = GetFrequencies(s);
            int[] integral = GetIntegral(frequencies);

            for (int i = 0; i < frequencies.Length; i++)
            {
                count += GetCount(s, frequencies, integral, i);
            }

            return count;
        }

        private static long GetCount(string s, int[] frequencies, int[] integral, int i)
        {
            long count = ((long)frequencies[i] * frequencies[i] + frequencies[i]) / 2;

            if (frequencies[i] == 1 && i != 0 && i != frequencies.Length - 1 && s[integral[i - 1] - 1] == s[integral[i + 1] - 1])
            {
                count += Math.Min(frequencies[i - 1], frequencies[i + 1]);
            }

            return count;
        }

        private static int[] GetIntegral(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            result[0] = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result[i] = result[i - 1] + numbers[i];
            }

            return result;
        }

        private static int[] GetFrequencies(string s)
        {
            List<int> frequencies = new List<int>();

            int count = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    count++;
                }
                else
                {
                    frequencies.Add(count);
                    count = 1;
                }
            }

            frequencies.Add(count);

            return frequencies.ToArray();
        }
    }
}
