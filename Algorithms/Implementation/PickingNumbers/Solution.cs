using System;

namespace PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(a);

            int startIndex = 0;
            int count = 1;
            int maxCount = 1;

            for (int i = 1; i < a.Length; i++)
            {
                if ((a[i] - a[startIndex]) <= 1)
                {
                    count++;

                    if (count > maxCount)
                        maxCount = count;
                }
                else
                {
                    count = 1;
                    startIndex = i;
                }
            }

            Console.WriteLine(maxCount);
        }
    }
}
