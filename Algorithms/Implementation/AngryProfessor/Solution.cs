using System;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int K = Int32.Parse(Console.ReadLine().Split(' ')[1]);

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

                int sum = 0;

                foreach (int n in arr)
                {
                    if (n <= 0)
                        sum++;
                }

                if (sum < K)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
