using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutingTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] NK = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));

                int N = NK[0];
                int K = NK[1];

                List<int> A = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();
                List<int> B = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x)).ToList();

                A.Sort();
                B.Sort();

                string output = "YES";

                for (int j = 0; j < N; j++)
                {
                    int diverence = K - A[j];

                    if (diverence > 0)
                    {
                        int element = B.FirstOrDefault(x => (x >= diverence));

                        if (B.Contains(element))
                            B.Remove(element);
                        else
                        {
                            output = "NO";
                            break;
                        }
                        
                    }
                    else
                        B.RemoveAt(0);
                }

                Console.WriteLine(output);
            }
        }
    }
}
