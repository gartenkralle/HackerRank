using System;

namespace CuttingPaperSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nm[0];
            int m = nm[1];

            Console.WriteLine(((long)n * m) - 1);
        }
    }
}
