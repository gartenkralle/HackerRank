using System;

namespace ConnectingTowns
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < T; i++)
            {
                int product = 1;
                int N = int.Parse(Console.ReadLine());

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                for (int j = 0; j < arr.Length; j++)
                {
                    product = (product * arr[j]) % 1234567;
                }

                Console.WriteLine(product);
            }
        }
    }
}
