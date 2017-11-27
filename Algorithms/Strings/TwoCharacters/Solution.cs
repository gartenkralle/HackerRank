using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoCharacters
{
    class Program
    {
        static void Main(String[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            Console.WriteLine(GetLongestAlternatingSequenceCount(s));
        }

        private static int GetLongestAlternatingSequenceCount(string s)
        {
            char[] chars = new HashSet<char>(s).ToArray();
            int maxCount = 0;

            for (int i = 0; i < (chars.Length - 1); i++)
            {
                for (int j = (i + 1); j < chars.Length; j++)
                {
                    int count = GetAlternatingSequenceCount(s, chars[i], chars[j]);

                    if (count > maxCount)
                        maxCount = count;
                }
            }

            return maxCount;
        }

        private static int GetAlternatingSequenceCount(string s, char firstChar, char secondChar)
        {
            int count = 0;

            bool foundFirstChar = false;
            bool foundSecondChar = false;

            foreach (char c in s)
            {
                if ((c == firstChar) && (foundFirstChar == false))
                {
                    count++;
                    foundFirstChar = true;
                    foundSecondChar = false;
                }
                else if ((c == secondChar) && (foundSecondChar == false))
                {
                    count++;
                    foundSecondChar = true;
                    foundFirstChar = false;
                }
                else if ((c == firstChar) || (c == secondChar))
                {
                    count = 0;
                    break;
                }
            }

            return count;
        }
    }
}
