using System;

namespace CircularArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = Int32.Parse(s[0]);
            int K = Int32.Parse(s[1]);
            int Q = Int32.Parse(s[2]);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

            K %= N;

            for (int i = 0; i < Q; i++)
            {
                int j = Int32.Parse(Console.ReadLine());

                int idx = ((j - K) < 0) ? (j - K + N) : (j - K);

                Console.WriteLine(arr[idx]);
            }
        }
    }
}
