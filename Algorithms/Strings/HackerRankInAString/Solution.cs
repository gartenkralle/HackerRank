using System;

namespace HackerRankInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            string h = "hackerrank";

            for (int i = 0; i < q; i++)
            {
                string s = Console.ReadLine();

                int hp = 0;
                string result = "NO";

                foreach (char c in s)
                {
                    if (c == h[hp])
                        hp++;

                    if (hp == h.Length)
                    {
                        result = "YES";
                        break;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
