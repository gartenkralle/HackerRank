using System;
using System.Collections.Generic;

namespace ClosestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));
            List<int> list = new List<int>(arr);
            list.Sort();

            int minDistance = Int32.MaxValue;

            for (int i = 0; i < (N-1); i++)
            {
                if ((list[i + 1] - list[i]) < minDistance)
                    minDistance = list[i + 1] - list[i];
            }

            List<int> res = new List<int>();

            for (int i = 0; i < (N - 1); i++)
            {
                if ((list[i + 1] - list[i]) == minDistance)
                {
                    res.Add(list[i]);
                    res.Add(list[i + 1]);
                }                    
            }

            Console.WriteLine(String.Join(" ", res.ToArray()));
        }
    }
}
