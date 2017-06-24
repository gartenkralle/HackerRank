using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();
                int numberOfDeletions = 0;

                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j] == s[j + 1])
                        numberOfDeletions++;
                }

                Console.WriteLine(numberOfDeletions);
            }
        }
    }
}
