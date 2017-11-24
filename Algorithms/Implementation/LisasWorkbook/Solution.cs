using System;

namespace LisasWorkbook
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = nk[0];
            int k = nk[1];

            int[] t = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(GetSpecialProblemsCount(t, n, k));
        }

        private static int GetSpecialProblemsCount(int[] t, int n, int k)
        {
            int count = 0;
            int chapter = 1;
            int page = 1;

            foreach (int problems in t)
            {
                for (int problem = 1; problem <= problems; problem++)
                {
                    if (problem == page)
                        count++;

                    if (((problem % k) == 0) || (problem == problems))
                        page++;
                }

                chapter++;
            }

            return count;
        }
    }
}
