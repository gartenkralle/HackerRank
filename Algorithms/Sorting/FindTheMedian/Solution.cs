using System;
using System.Collections.Generic;

namespace FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));
            List<int> list = new List<int>(arr);

            list.Sort();

            Console.WriteLine(list[list.Count / 2]);
        }
    }
}
