using System;

namespace InsertionSortPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            int last = arr[size - 1];

            for (int i = (size - 1); i > 0; i--)
            {
                if (arr[i - 1] > last)
                {
                    arr[i] = arr[i - 1];
                    Console.WriteLine(String.Join(" ", arr));
                }
                else
                {
                    arr[i] = last;
                    Console.WriteLine(String.Join(" ", arr));
                    break;
                }
            }

            if(last < arr[0])
            {
                arr[0] = last;
                Console.WriteLine(String.Join(" ", arr));
            }
        }
    }
}
