using System;

namespace SecurityPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[arr[i] - 1]);
            }
        }
    }
}
