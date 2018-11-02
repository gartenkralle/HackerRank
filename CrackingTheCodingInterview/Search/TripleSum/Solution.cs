using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            long res = Triplets(a, b, c);

            Console.WriteLine(res);
        }

        static long Triplets(int[] a, int[] b, int[] c)
        {
            long count = 0;

            Array.Sort(a);
            Array.Sort(b);
            Array.Sort(c);

            a = a.Distinct().ToArray();
            b = b.Distinct().ToArray();
            c = c.Distinct().ToArray();
            
            int indexA = 0;
            int indexC = 0;
             
            foreach(int element in b)
            {
                while ((indexA < a.Length) && (a[indexA] <= element))
                    indexA++;

                while ((indexC < c.Length) && (c[indexC] <= element))
                    indexC++;

                count += (long)indexA * indexC;
            }

            return count;
        }
    }
}
