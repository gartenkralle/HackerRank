using System;

namespace EqualizeTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] count = new int[101];
            int max = 0;

            Array.Sort(a);

            for (int i = 0; i < n; i++)
                count[a[i]]++;

            for (int i = 0; i < count.Length; i++)
                if (count[i] > max)
                    max = count[i];

            Console.WriteLine(n - max);
        }
    }
}
