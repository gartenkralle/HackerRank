using System;
using System.Collections.Generic;
using System.Linq;

namespace Day0_MeanMedianAndMode
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] arr;

            float mean, median, mode;

            arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            mean = (float)arr.Sum() / N;

            int[] sorted = new int[N];
            Array.Copy(arr, sorted, N);
            Array.Sort(sorted);

            median = (float)(sorted[N / 2] + sorted[N / 2 - 1]) / 2;

            CountingDictionary<int> ints = new CountingDictionary<int>();
            mode = ints.getMode(arr);

            Console.WriteLine(String.Format("{0:0.#}", mean));
            Console.WriteLine(String.Format("{0:0.#}", median));
            Console.WriteLine(String.Format("{0:0.#}", mode));
        }
    }

    class CountingDictionary<T> where T : IComparable<T>
    {
        private Dictionary<T, int> dictionary = new Dictionary<T, int>();
        
        private void Add(T key)
        {
            if (dictionary.ContainsKey(key))
                dictionary[key]++;
            else
                dictionary.Add(key, 1);
        }

        public T getMode(T[] arr)
        {
            foreach (T t in arr)
                Add(t);

            KeyValuePair<T, int> currentKvp = new KeyValuePair<T, int>();

            foreach (KeyValuePair<T, int> kvp in dictionary)
            {
                if ((kvp.Value > currentKvp.Value) || ((kvp.Value == currentKvp.Value) && (kvp.Key.CompareTo(currentKvp.Key) < 0)))
                    currentKvp = kvp;
            }

            return currentKvp.Key;
        }
    }
}
