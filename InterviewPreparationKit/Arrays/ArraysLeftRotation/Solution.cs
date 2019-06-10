using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ArraysLeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            int[] res = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
                res[i] = a[(i + d) % n];

            Console.WriteLine(string.Join(" ", res));
        }
    }
}
