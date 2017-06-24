using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<int> A = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();
            int m = Int32.Parse(Console.ReadLine());
            List<int> B = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();

            A.Sort();
            B.Sort();

            int idxA = 0;
            int idxB = 0;

            List<int> res = new List<int>();

            while (idxB < B.Count)
            {
                if ((idxA == A.Count) || (A[idxA] != B[idxB]))
                {
                    res.Add(B[idxB]);
                    idxA--;
                }

                idxA++;
                idxB++;
            }

            Console.WriteLine(String.Join(" ", res.ToArray().Distinct()));
        }
    }
}
