using System;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            string[] lines = readLines(N);

            int Q = Int32.Parse(Console.ReadLine());

            string[] queries = readLines(Q);

            for (int i = 0; i < Q; i++)
                Console.WriteLine(getMatchCount(lines, queries[i]));
        }

        static int getMatchCount(string[] lines, string query)
        {
            int count = 0;

            foreach (string line in lines)
                if (line == query)
                    count++;

            return count;
        }

        static string[] readLines(int n)
        {
            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
                lines[i] = Console.ReadLine();

            return lines;
        }
    }
}
