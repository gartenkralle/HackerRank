using System;

namespace AppendAndDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            int longestCommonLength = calculateLongestCommoLength(s, t);

            int firstDiff = s.Length - longestCommonLength;
            int secondDiff = t.Length - longestCommonLength;

            int result = firstDiff + secondDiff;

            if ((isEven(result) == isEven(k) && (k >= result)) || (k > (s.Length + t.Length)))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        private static int calculateLongestCommoLength(string s, string t)
        {
            int length = 0;

            int lengthOfShortestString = (s.Length < t.Length) ? s.Length : t.Length;

            for (int i = 0; i < lengthOfShortestString; i++)
            {
                if (s[i] == t[i])
                    length++;
                else
                    return length;
            }

            return length;
        }

        private static bool isEven(int number)
        {
            return (number % 2) == 0;
        }
    }
}
