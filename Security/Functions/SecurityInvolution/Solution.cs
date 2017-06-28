using System;

namespace SecurityInvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            string result = "YES";

            for (int i = 0; i < n; i++)
            {
                if (arr[arr[i] - 1] != i + 1)
                    result = "NO";
            }

            Console.WriteLine(result);
        }
    }
}
