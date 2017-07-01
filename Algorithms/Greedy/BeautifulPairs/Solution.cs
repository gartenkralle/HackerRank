using System;

namespace BeautifulPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(A);
            Array.Sort(B);

            int skipped = 0;
            int count = 0;

            int indexX = 0;
            int indexY = 0;

            while((indexX < N) && (indexY < N))
            {
                if(A[indexX] == B[indexY])
                {
                    count++;
                    indexX++;
                    indexY++;
                }
                else if(A[indexX] < B[indexY])
                {
                    indexX++;
                    skipped++;
                }
                else
                {
                    indexY++;
                    skipped++;
                }
            }

            if (skipped > 0)
                count++;
            else
                count--;

            Console.WriteLine(count);
        }
    }
}
