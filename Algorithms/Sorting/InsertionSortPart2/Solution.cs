using System;

namespace InsertionSortPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            for (int i = 1; i < size; i++)
            {
                int last = arr[i];

                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > last)
                        arr[j] = arr[j - 1];
                    else
                    {
                        arr[j] = last;
                        break;
                    }
                }

                if (last < arr[0])
                    arr[0] = last;

                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}
