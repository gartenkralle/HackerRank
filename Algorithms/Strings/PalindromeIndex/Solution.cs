using System;

namespace PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                string s = Console.ReadLine();

                int result = PalindromeIndex(s);

                Console.WriteLine(result);
            }
        }

        static int PalindromeIndex(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    s = s.Remove(i, 1);

                    if (IsPalindrome(s))
                        return i;
                    else
                        return s.Length - i;
                }
            }

            return -1;
        }

        private static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
