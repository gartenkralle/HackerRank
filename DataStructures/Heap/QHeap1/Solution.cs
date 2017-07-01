using System;
using System.Collections.Generic;

namespace QHeap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            Heap heap = new Heap(q);

            for (int i = 0; i < q; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int type = arr[0];
                int v;

                switch (type)
                {
                    case 1:
                        v = arr[1];
                        heap.Add(v);
                        break;

                    case 2:
                        v = arr[1];
                        heap.Delete(v);
                        break;

                    case 3:
                        Console.WriteLine(heap.Min);
                        break;
                }
            }
        }
    }

    class Heap
    {
        private int[] heap;
        private Dictionary<int, int> dict;

        private int lastIndex;

        public int Min
        {
            get { return heap[1]; }
        }

        public Heap(int size)
        {
            heap = new int[size + 1];
            dict = new Dictionary<int, int>();
        }

        public void Add(int v)
        {
            lastIndex++;

            heap[lastIndex] = v;
            dict.Add(v, lastIndex);

            int index = lastIndex;

            while ((index > 1) && (v < heap[index / 2]))
            {
                SwapByIndex(index, index / 2);
                UpdateDictionary(index, index / 2);

                index /= 2;
            }
        }

        public void Delete(int v)
        {
            int index = dict[v];
            SwapByIndex(index, lastIndex);
            UpdateDictionary(index, lastIndex);
            dict.Remove(v);
            lastIndex--;

            int minChildIndex = GetMinChildIndex(index);

            while ((minChildIndex != -1) && (heap[minChildIndex] < heap[index]))
            {
                SwapByIndex(index, minChildIndex);
                UpdateDictionary(index, minChildIndex);

                index = minChildIndex;
                minChildIndex = GetMinChildIndex(index);
            }
        }

        private int GetMinChildIndex(int rootIndex)
        {
            if (lastIndex > (2 * rootIndex))
                return (heap[2 * rootIndex] < heap[(2 * rootIndex) + 1]) ? (2 * rootIndex) : ((2 * rootIndex) + 1);
            if (lastIndex == (2 * rootIndex))
                return 2 * rootIndex;
            else
                return -1;
        }

        private void UpdateDictionary(int index, int minChildIndex)
        {
            dict[heap[index]] = index;
            dict[heap[minChildIndex]] = minChildIndex;
        }

        private void SwapByIndex(int i, int j)
        {
            int temp = heap[j];
            heap[j] = heap[i];
            heap[i] = temp;
        }
    }
}
