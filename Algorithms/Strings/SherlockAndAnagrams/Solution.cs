using System;

namespace SherlockAndAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string s = Console.ReadLine();

                Console.WriteLine(GetUnorderedAnagrammaticPairsCount(s));
            }
        }

        private static int GetUnorderedAnagrammaticPairsCount(string s)
        {
            int count = 0;

            for (int i = 1; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - i; j++)
                {
                    for (int k = j + 1; k < s.Length - i + 1; k++)
                    {
                        string s1 = s.Substring(j, i);
                        string s2 = s.Substring(k, i);

                        if (s1.IsAnagram(s2))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }

    static class MyExtensions
    {
        public static bool IsAnagram(this string s1, string s2)
        {
            int[] alphabet = new int[26];

            CountCharacters(alphabet, s1, 1);
            CountCharacters(alphabet, s2, -1);

            return IsAnagram(alphabet);
        }

        private static bool IsAnagram(int[] alphabet)
        {
            foreach (int n in alphabet)
            {
                if (n != 0)
                    return false;
            }

            return true;
        }

        static void CountCharacters(int[] arr, string s, int n)
        {
            foreach (char c in s)
            {
                arr[c - 'a'] += n;
            }
        }
    }
}
