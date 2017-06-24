using System;

namespace CountingSort2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.ReadLine();

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int maxValue = 100;
            int[] counts = new int[maxValue];

            for (int i = 0; i < arr.Length; i++)
                counts[arr[i]]++;

            int index = 0;

            for (int i = 0; i < counts.Length; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    arr[index] = i;
                    index++;
                }
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
