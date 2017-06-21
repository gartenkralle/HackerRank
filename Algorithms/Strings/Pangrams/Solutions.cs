using System;
using System.Collections.Generic;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();

            Dictionary<char, bool> alphabet = new Dictionary<char, bool>();

            foreach (char c in s)
            {
                if (c != ' ')
                    alphabet[c] = true;
            }

            if (alphabet.Count == 26)
                Console.WriteLine("pangram");
            else
                Console.WriteLine("not pangram");

        }
    }
}
