using System;

namespace RunningTimeOfQuicksort
{
    class Program
    {
        static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));
            int[] arr2 = new int[size];
            Array.Copy(arr, arr2, size);

            int count = 0;
            quickSort(arr, 0, (arr.Length - 1), ref count);

            int count2 = 0;
            insertionSort(arr2, ref count2);

            Console.WriteLine(count2 - count);
        }

        static void insertionSort(int[] arr, ref int count)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int last = arr[i];

                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > last)
                    {
                        arr[j] = arr[j - 1];
                        count++;
                    }
                    else
                    {
                        arr[j] = last;
                        break;
                    }
                }

                if (last < arr[0])
                    arr[0] = last;
            }
        }

        static void quickSort(int[] arr, int lo, int hi, ref int count)
        {
            if (lo < hi)
            {
                int p = partition(arr, lo, hi, ref count);

                quickSort(arr, lo, p - 1, ref count);
                quickSort(arr, p + 1, hi, ref count);
            }
        }

        static int partition(int[] arr, int lo, int hi, ref int count)
        {
            int pivot = arr[hi];
            int i = lo;

            for (int j = lo; j < hi; j++)
            {
                if (arr[j] <= pivot)
                {
                    swap(arr, i, j, ref count);
                    i++;
                }
            }

            swap(arr, i, hi, ref count);

            return i;
        }

        static void swap(int[] arr, int i, int j, ref int count)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
            count++;
        }
    }
}
