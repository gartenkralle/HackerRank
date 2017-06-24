using System;
using System.Collections.Generic;

namespace Quicksort1Partition
{
    class Program
    {
        static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));

            partition(arr);

            Console.WriteLine(String.Join(" ", arr));
        }

        static void partition(int[] arr)
        {
            List<int> lower = new List<int>();
            List<int> higher = new List<int>();
            int pivot = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > pivot)
                    higher.Add(arr[i]);
                else
                    lower.Add(arr[i]);
            }

            for (int i = 0; i < lower.Count; i++)
                arr[i] = lower[i];

            arr[lower.Count] = pivot;

            for (int i = (lower.Count + 1); i < (lower.Count + 1 + higher.Count); i++)
                arr[i] = higher[i-(lower.Count + 1)];
        }
    }
}
