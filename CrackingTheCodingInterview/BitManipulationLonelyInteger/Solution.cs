using System;
using System.Collections.Generic;
using System.Linq;

namespace LonelyInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            List<int> list = arr.ToList();
            SortedSet<int> ss = new SortedSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!ss.Add(arr[i]))
                    list.RemoveAll(x => (x == arr[i]));
            }

            Console.WriteLine(list[0]);
        }
    }
}
