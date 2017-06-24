using System;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int fromStart = p / 2;
            int fromEnd = (n - p) / 2;

            int minPages;

            if (fromStart < fromEnd)
                minPages = fromStart;
            else
                minPages = fromEnd;

            Console.WriteLine(minPages);
        }
    }
}
