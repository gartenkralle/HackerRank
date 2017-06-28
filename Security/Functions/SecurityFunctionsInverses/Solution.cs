using System;

namespace SecurityFunctionInverses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[arr[i] - 1] = i + 1;
            }

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
