using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = i+1; j < N; j++)
                    Console.Write(' ');

                for (int j = 0; j < i+1; j++)
                    Console.Write('#');

                Console.WriteLine();
            }
        }
    }
}
