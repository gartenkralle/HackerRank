using System;
using System.Collections.Generic;

namespace Day8_DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < N; i++)
            {
                string[] nameNumber = Console.ReadLine().Split(' ');
                string name = nameNumber[0];
                int number = Int32.Parse(nameNumber[1]);

                dict.Add(name, number);
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (dict.ContainsKey(name))
                    Console.WriteLine(name + "=" + dict[name]);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}
