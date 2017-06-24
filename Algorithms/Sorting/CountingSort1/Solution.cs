using System;

namespace CountingSort1
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int maxValue = 100;
            int[] counts = new int[maxValue];

            for (int i = 0; i < arr.Length; i++)
            {
                counts[arr[i]]++;
            }

            Console.WriteLine(String.Join(" ", counts));
        }
    }
}
