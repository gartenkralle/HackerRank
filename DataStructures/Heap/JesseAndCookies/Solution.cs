using System;

namespace JesseAndCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int N = nk[0];
            int K = nk[1];

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Heap heap = new Heap(N);

            foreach (int number in A)
            {
                heap.Add(number);
            }

            int count = 0;

            while ((heap.Size >= 2) && (heap.PeakMin() < K))
            {
                int first = heap.PeakMin();
                heap.DeleteMin();

                int second = heap.PeakMin();
                heap.DeleteMin();

                heap.Add(first + (2 * second));

                count++;
            }

            if (heap.PeakMin() < K)
            {
                count = -1;
            }

            Console.WriteLine(count);
        }
    }

    class Heap
    {
        private readonly int[] arr;
        private int index = -1;

        public int Size
        {
            get
            {
                return index + 1;
            }
        }

        public Heap(int size)
        {
            arr = new int[size];
        }

        public void Add(int data)
        {
            index++;
            arr[index] = data;

            if (Size > 1)
            {
                HeapifyButtomUp(arr);
            }
        }

        public int PeakMin()
        {
            return arr[0];
        }

        public void DeleteMin()
        {
            arr[0] = arr[index];
            index--;

            if (Size > 1)
            {
                HeapifyTopDown(arr);
            }
        }

        private void HeapifyButtomUp(int[] arr)
        {
            int childIndex = index;
            int parentIndex = (childIndex - 1) / 2;

            while (arr[childIndex] < arr[parentIndex])
            {
                Swap(ref arr[childIndex], ref arr[parentIndex]);

                childIndex = parentIndex;
                parentIndex = (childIndex - 1) / 2;
            }
        }

        private void HeapifyTopDown(int[] arr)
        {
            int parentIndex = 0;
            int childIndex = 0;

            if (Size >= 3)
            {
                childIndex = arr[1] < arr[2] ? 1 : 2;
            }
            else if (Size == 2)
            {
                childIndex = 1;
            }

            while (arr[parentIndex] > arr[childIndex])
            {
                Swap(ref arr[parentIndex], ref arr[childIndex]);

                parentIndex = childIndex;

                if (Size > (2 * childIndex) + 2)
                {
                    childIndex = arr[(2 * childIndex) + 1] < arr[(2 * childIndex) + 2] ? (2 * childIndex) + 1 : (2 * childIndex) + 2;
                }
                else if (Size > (2 * childIndex) + 1)
                {
                    childIndex = (2 * childIndex) + 1;
                }
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
