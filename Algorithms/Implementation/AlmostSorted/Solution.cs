using System;

namespace AlmostSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            AlmostSorted(arr);
        }

        static void AlmostSorted(int[] arr)
        {
            if (IsSorted(arr))
            {
                Console.WriteLine("yes");
            }
            else
            {
                int indexBegin = GetBeginIndex(arr);
                int indexEnd = GetEndIndex(arr);

                Swap(arr, indexBegin, indexEnd);

                if (IsSorted(arr))
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("swap " + (indexBegin + 1) + " " + (indexEnd + 1));

                    return;
                }

                Swap(arr, indexBegin, indexEnd);
                Reverse(arr, indexBegin, indexEnd);

                if (IsSorted(arr))
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("reverse " + (indexBegin + 1) + " " + (indexEnd + 1));

                    return;
                }

                Console.WriteLine("no");
            }
        }

        private static void Reverse(int[] arr, int indexBegin, int indexEnd)
        {
            int index = (indexEnd - indexBegin + 1) / 2;

            for (int i = 0; i < index; i++)
            {
                Swap(arr, indexBegin + i, indexEnd - i);
            }
        }

        private static void Swap(int[] arr, int indexBegin, int indexEnd)
        {
            if ((indexBegin == -1) || (indexEnd == -1))
                return;

            int temp = arr[indexBegin];
            arr[indexBegin] = arr[indexEnd];
            arr[indexEnd] = temp;
        }

        private static int GetEndIndex(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                if (arr[i] < arr[i - 1])
                {
                    return i;
                }
            }

            return -1;
        }

        private static int GetBeginIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
