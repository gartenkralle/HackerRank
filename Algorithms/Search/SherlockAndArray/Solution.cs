using System;
using System.Linq;

namespace SherlockAndArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(Console.ReadLine());

                string[] arr = Console.ReadLine().Split(' ');
                int[] A = new int[N];

                for (int j = 0; j < N; j++)
                {
                    A[j] = Int32.Parse(arr[j]);
                }

                int sumLeft = 0;
                int sumRight = A.Sum() - A[0];
                string equal = (sumLeft == sumRight) ? "YES" : "NO";

                for (int j = 0; j < N - 1; j++)
                {
                    sumLeft += A[j];
                    sumRight -= A[j + 1];

                    if (sumLeft == sumRight)
                        equal = "YES";
                }

                Console.WriteLine(equal);
            }
        }
    }
}
