using System;
using System.Collections.Generic;

namespace LargestPermutation
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int N = NK[0];
            int K = NK[1];

            int[] permutation = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(String.Join(" ", (GetLargestPermutation(permutation, K))));
        }

        private static int[] GetLargestPermutation(int[] permutation, int K)
        {
            int N = permutation.Length;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                dictionary.Add(permutation[i], i);
            }

            int swapCount = 0;

            for (int i = 0; i < N; i++)
            {
                if (swapCount == K)
                {
                    break;
                }

                int index1, index2;

                if (i < dictionary[N - i])
                {
                    index1 = i;
                    index2 = dictionary[N - i];
                }
                else
                {
                    index1 = dictionary[N - i];
                    index2 = i;
                }

                if (permutation[index1] < permutation[index2])
                {
                    Swap(dictionary, permutation, index1, index2);

                    swapCount++;
                }
            }

            return permutation;
        }

        private static void Swap(Dictionary<int, int> dictionary, int[] permutation, int index1, int index2)
        {
            int temp = permutation[index1];
            permutation[index1] = permutation[index2];
            permutation[index2] = temp;

            temp = dictionary[permutation[index1]];
            dictionary[permutation[index1]] = dictionary[permutation[index2]];
            dictionary[permutation[index2]] = temp;
        }
    }
}
