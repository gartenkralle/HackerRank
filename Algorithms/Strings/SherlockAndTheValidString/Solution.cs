using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();

            Console.WriteLine(IsValid(s));
        }

        static string IsValid(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!charCount.ContainsKey(c))
                    charCount.Add(c, 1);
                else
                    charCount[c]++;
            }

            Dictionary<int, int> setCount = new Dictionary<int, int>();

            foreach (KeyValuePair<char, int> keyValuePair in charCount)
            {
                if (!setCount.ContainsKey(keyValuePair.Value))
                    setCount.Add(keyValuePair.Value, 1);
                else
                    setCount[keyValuePair.Value]++;
            }

            if (ContainsOneCharacterType(setCount) || (ContainsTwoCharacterTypes(setCount) && (ContainsUniqueCharacter(setCount) || (ContainsRemovableCharacter(setCount)))))
                return "YES";
            else
                return "NO";
        }

        static bool ContainsOneCharacterType(Dictionary<int, int> dictionary)
        {
            return dictionary.Count == 1;
        }

        static bool ContainsTwoCharacterTypes(Dictionary<int, int> dictionary)
        {
            return dictionary.Count == 2;
        }

        static bool ContainsUniqueCharacter(Dictionary<int, int> dictionary)
        {
            return ((dictionary.ElementAt(0).Key == 1) && (dictionary.ElementAt(0).Value == 1)) || ((dictionary.ElementAt(1).Key == 1) && (dictionary.ElementAt(1).Value == 1));
        }

        static bool ContainsRemovableCharacter(Dictionary<int, int> setCount)
        {
            return (((setCount.ElementAt(0).Key - setCount.ElementAt(1).Key) == 1) && (setCount.ElementAt(0).Value == 1)) ||
                   (((setCount.ElementAt(1).Key - setCount.ElementAt(0).Key) == 1) && (setCount.ElementAt(1).Value == 1));
        }
    }
}
