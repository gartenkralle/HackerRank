using System;
using System.Linq;
using System.Collections.Generic;

namespace ClimbingTheLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int m = int.Parse(Console.ReadLine());
            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            List<int> distinctScores = scores.Distinct().ToList();

            for (int i = 0; i < m; i++)
            {
                while ((distinctScores.Count > 0) && (alice[i] >= distinctScores[distinctScores.Count - 1]))
                    distinctScores.RemoveAt(distinctScores.Count - 1);

                int place = distinctScores.Count + 1;

                Console.WriteLine(place);
            }
        }
    }
}
