using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTablesRansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            List<string> magazine = Console.ReadLine().Split(' ').ToList();
            List<string> ransomeNote = Console.ReadLine().Split(' ').ToList();

            magazine.Sort();
            ransomeNote.Sort();

            foreach(string word in ransomeNote)
            {
                int index = magazine.BinarySearch(word);

                if(index < 0)
                {
                    Console.WriteLine("No");
                    return;
                }
                else
                {
                    magazine.RemoveAt(index);
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
