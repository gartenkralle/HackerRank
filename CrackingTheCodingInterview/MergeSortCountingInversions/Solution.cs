using System;

namespace MergeSortCountingInversions
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

                long result = CountInversions(arr);

                Console.WriteLine(result);
            }
        }

        static long CountInversions(int[] arr)
        {
            return Sort(arr);
        }

        public static long Sort(int[] a)
        {
            int[] aux = new int[a.Length];

            return Sort(a, aux, 0, a.Length - 1);
        }

        private static long Sort(int[] a, int[] aux, int lo, int hi)
        {
            long count = 0;

            if (hi <= lo)
            {
                return count;
            }

            int mid = lo + ((hi - lo) / 2);

            count += Sort(a, aux, lo, mid);
            count += Sort(a, aux, mid + 1, hi);

            count += Merge(a, aux, lo, mid, hi);

            return count;
        }

        private static long Merge(int[] a, int[] aux, int lo, int mid, int hi)
        {
            long count = 0;

            for (int k = lo; k <= hi; k++)
            {
                aux[k] = a[k];
            }

            int i = lo;
            int j = mid + 1;

            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                {
                    a[k] = aux[j];
                    j++;
                }
                else if (j > hi)
                {
                    a[k] = aux[i];
                    i++;
                }
                else if (aux[j] < aux[i])
                {
                    a[k] = aux[j];
                    count += (j - k);
                    j++;
                }
                else
                {
                    a[k] = aux[i];
                    i++;
                }
            }

            return count;
        }
    }
}
