using System;

namespace MinimumSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int res = MinimumSwaps(arr);

            Console.WriteLine(res);
        }

        static int MinimumSwaps(int[] arr)
        {
            int[] positions = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                positions[arr[i] - 1] = i;
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int index = positions[i];

                if (index != i)
                {
                    Swap(ref arr[i], ref arr[index]);
                    Swap(ref positions[arr[i] - 1], ref positions[arr[index] - 1]);

                    count++;
                }
            }

            return count;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
