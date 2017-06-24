using System;
using System.Collections.Generic;

namespace TheFullCountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 100;
            int n = Int32.Parse(Console.ReadLine());
            Entry[] entries = new Entry[n];
            List<Entry>[] listArray = new List<Entry>[maxValue];

            for (int i = 0; i < maxValue; i++)
                listArray[i] = new List<Entry>();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Entry entry = new Entry();
                entry.Position = Int32.Parse(s[0]);

                if (i < (n / 2))
                    entry.Word = "-";
                else
                    entry.Word = s[1];

                listArray[entry.Position].Add(entry);
            }

            List<string> res = new List<string>();

            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < listArray[i].Count; j++)
                {
                    res.Add(listArray[i][j].Word);
                }
            }

            Console.WriteLine(String.Join(" ", res.ToArray()));
        }
    }

    struct Entry
    {
        public int Position { get; set; }
        public string Word { get; set; }
    }
}
