using System;
using System.Collections.Generic;

namespace SequenceEquation
{
    class Program
    {
        static int[] arr;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 1; i < (n + 1); i++)
                dict.Add(arr[i - 1], i);

            for (int i = 1; i < (n + 1); i++)
                Console.WriteLine(dict[dict[i]]);
        }
    }
}
