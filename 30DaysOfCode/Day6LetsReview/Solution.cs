using System;

namespace Day6LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();

                for (int j = 0; j < s.Length; j += 2)
                    Console.Write(s[j]);

                Console.Write(" ");

                for (int j = 1; j < s.Length; j += 2)
                    Console.Write(s[j]);

                Console.WriteLine();
            }
        }
    }
}
