using System;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(Console.ReadLine());
                int height = 1;

                for (int j = 0; j < N; j++)
                {
                    if ((j % 2) == 0)
                        height *= 2;
                    else
                        height++;
                }

                Console.WriteLine(height);
            }
        }
    }
}
