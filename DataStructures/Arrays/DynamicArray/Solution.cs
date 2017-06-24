using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');

            int N = Int32.Parse(firstLine[0]);
            int testCaseCount = Int32.Parse(firstLine[1]);

            List<int>[] seqList = new List<int>[N];

            for (int i= 0; i < N; i++)
                seqList[i] = new List<int>();

            int lastAns = 0;

            for (int i = 0; i < testCaseCount; i++)
            {
                int[] query = Array.ConvertAll(Console.ReadLine().Split(' '), _x => Int32.Parse(_x));

                int type = query[0];
                int x = query[1];
                int y = query[2];

                int index = ((x ^ lastAns) % N);

                List<int> seq = seqList[index];

                if (type == 1)
                {
                    seq.Add(y);
                }
                else
                {
                    lastAns = seq[y % seq.Count];

                    Console.WriteLine(lastAns);
                }
            }
        }
    }
}
