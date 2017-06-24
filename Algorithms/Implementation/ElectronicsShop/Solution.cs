using System;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] snm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int s = snm[0];
            int n = snm[1];
            int m = snm[2];

            int[] nArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] mArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int maxSum = -1;

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    int sum = nArr[i] + mArr[k];

                    if ((sum <= s) && (sum > maxSum))
                        maxSum = sum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
