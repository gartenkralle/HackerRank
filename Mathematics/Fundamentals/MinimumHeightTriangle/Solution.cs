using System;

namespace MinimumHeightTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ba = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int b = ba[0];
            int a = ba[1];

            int h = (int)Math.Ceiling((((decimal)a * 2) / b));

            Console.WriteLine(h);
        }
    }
}
