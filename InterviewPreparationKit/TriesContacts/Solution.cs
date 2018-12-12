using System;
using System.Collections.Generic;

namespace TriesContacts
{
    class Program
    {
        static void Main(string[] args)
        {
            int queriesRows = Convert.ToInt32(Console.ReadLine());

            string[][] queries = new string[queriesRows][];

            for (int i = 0; i < queriesRows; i++)
            {
                queries[i] = Console.ReadLine().Split(' ');
            }

            int[] result = Contacts(queries);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        static int[] Contacts(string[][] queries)
        {
            List<int> results = new List<int>();
            Trie trie = new Trie();

            for (int i = 0; i < queries.Length; i++)
            {
                switch (queries[i][0])
                {
                    case "add":
                        trie.Add(queries[i][1]);
                        break;

                    case "find":
                        results.Add(trie.Find(queries[i][1]));
                        break;
                }
            }

            return results.ToArray();
        }
    }

    class Trie
    {
        private Trie[] subTries;
        private int count;

        public Trie()
        {
            subTries = new Trie[26];
        }

        public void Add(string name)
        {
            Trie[] currentTries = subTries;

            foreach (char character in name)
            {
                int index = ToIndex(character);

                if (currentTries[index] == null)
                {
                    currentTries[index] = new Trie();
                }

                currentTries[index].count++;

                currentTries = currentTries[index].subTries;
            }
        }

        public int Find(string partial)
        {
            Trie[] subTries = this.subTries;
            Trie currentTrie = null;

            int index = 0;

            foreach (char character in partial)
            {
                index = ToIndex(character);

                if (subTries[index] != null)
                {
                    currentTrie = subTries[index];
                    subTries = currentTrie.subTries;
                }
                else
                {
                    return 0;
                }
            }

            return currentTrie.count;
        }

        private int ToIndex(char character)
        {
            return Convert.ToInt32(character) - 97;
        }
    }
}
