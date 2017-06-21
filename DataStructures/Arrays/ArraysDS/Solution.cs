using System;

namespace ArraysDS
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));

            Array.Reverse(A);

            Console.WriteLine(String.Join(" ", A));
        }
    }
}
