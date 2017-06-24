using System;

namespace QuicksortInPlace
{
    class Program
    {
        static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));

            quickSort(arr, 0, (arr.Length - 1));
        }

        static void quickSort(int[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(arr, lo, hi);

                quickSort(arr, lo, p - 1);
                quickSort(arr, p + 1, hi);
            }
        }

        static int partition(int[] arr, int lo, int hi)
        {
            int pivot = arr[hi];
            int i = lo;

            for (int j = lo; j < hi; j++)
            {
                if (arr[j] <= pivot)
                {
                    swap(arr, i, j);
                    i++;
                }
            }

            swap(arr, i, hi);

            Console.WriteLine(String.Join(" ", arr));

            return i;
        }

        static void swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
