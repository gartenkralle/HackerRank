using System;

namespace CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int min = Min(arr);

            while (min != Int32.MaxValue)
            {
                Console.WriteLine(Count(arr));
                Cut(arr, min);
                min = Min(arr);
            }
        }

        static int Count(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    count++;
            }

            return count;
        }

        static int Min(int[] arr)
        {
            int min = Int32.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] < min) && (arr[i] != 0))
                    min = arr[i];
            }

            return min;
        }

        static void Cut(int[] arr, int length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    arr[i] -= length;
            }
        }
    }
}
