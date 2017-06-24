using System;

namespace Quicksort2Sorting
{
    class Program
    {
        static void Main(String[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => Int32.Parse(s));

            quickSort(arr, 0, (arr.Length - 1));
        }

        static void quickSort(int[] arr, int start, int end)
        {
            if ((end - start + 1) <= 1)
                return;

            int[] tmp = new int[arr.Length];
            Array.Copy(arr, tmp, arr.Length);

            int currentIdx = start;
            int pivot = arr[currentIdx];

            for (int i = (start + 1); i <= end; i++)
            {
                if (tmp[i] < pivot)
                {
                    arr[currentIdx] = tmp[i];
                    currentIdx++;
                }
            }

            arr[currentIdx] = pivot;
            int pivotIdx = currentIdx;
            currentIdx++;

            for (int i = (start + 1); i <= end; i++)
            {
                if (tmp[i] > pivot)
                {
                    arr[currentIdx] = tmp[i];
                    currentIdx++;
                }
            }

            quickSort(arr, start, pivotIdx - 1);
            quickSort(arr, pivotIdx + 1, end);

            Console.WriteLine(String.Join(" ", Array.ConvertAll(arr, i => i.ToString()), start, end - start + 1));
        }
    }
}
