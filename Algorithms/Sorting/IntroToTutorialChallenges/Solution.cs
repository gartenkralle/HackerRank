using System;
using System.Collections.Generic;

namespace IntroToTutorialChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = Int32.Parse(Console.ReadLine());
            int n = Int32.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(' ');
            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Int32.Parse(s[i]));
            }

            Console.WriteLine(arr.IndexOf(V));
        }
    }
}
