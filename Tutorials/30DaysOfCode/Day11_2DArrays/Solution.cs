using System;

namespace Day11_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            }

            int maxSum = Int32.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = arr[0 + i][0 + j] +
                              arr[0 + i][1 + j] +
                              arr[0 + i][2 + j] +
                              arr[1 + i][1 + j] +
                              arr[2 + i][0 + j] +
                              arr[2 + i][1 + j] +
                              arr[2 + i][2 + j];

                    if (sum > maxSum)
                        maxSum = sum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
