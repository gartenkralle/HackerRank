using System;
using System.Collections.Generic;
using System.Linq;

namespace KFactorization
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(A);
            Array.Reverse(A);

            Console.WriteLine(GetMultipliedKFactorization(A, n));
        }

        private static string GetMultipliedKFactorization(int[] a, int n)
        {
            int[] kFactorization = GetLexicographicallySmallest(GetKFactorizations(a, n));

            string result;

            if (kFactorization == null)
            {
                result = "-1";
            }
            else
            {
                result = String.Join(" ", GetMultipliedSeries(kFactorization));
            }

            return result;
        }

        private static List<int[]> GetKFactorizations(int[] a, int n)
        {
            List<int[]> kFactorizations = new List<int[]>();
            List<int> list = a.ToList();

            for (int i = 0; i < (a.Length - 1); i++)
            {
                int[] kFactorization = Array.ConvertAll(GetKFactorization(list, n).Split(' '), int.Parse);

                if (kFactorization[0] != -1)
                {
                    kFactorizations.Add(kFactorization);
                }

                list.RemoveAt(0);
            }

            return kFactorizations;
        }

        private static int[] GetLexicographicallySmallest(List<int[]> list)
        {
            int[] smallest = null;

            if (list.Count != 0)
                smallest = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Length < smallest.Length)
                {
                    smallest = list[i];
                }
                else if (list[i].Length == smallest.Length)
                {
                    smallest = GetLexicographicallySmallest(list[i], smallest);
                }
            }

            return smallest;
        }

        private static int[] GetLexicographicallySmallest(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < b[i])
                {
                    return a;
                }
                else if (b[i] < a[i])
                {
                    return b;
                }
            }

            return a;
        }

        private static string GetKFactorization(List<int> a, int n)
        {
            if (n == 1)
                return "1";

            foreach (int number in a)
            {
                if (IsDivisible(n, number))
                {
                    return GetKFactorization(a, (n / number)) + " " + number;
                }
            }

            return "-1";
        }

        private static bool IsDivisible(int nominator, int denominator)
        {
            return (nominator % denominator) == 0;
        }

        private static int[] GetMultipliedSeries(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                a[i] *= a[i - 1];
            }

            return a;
        }
    }
}
