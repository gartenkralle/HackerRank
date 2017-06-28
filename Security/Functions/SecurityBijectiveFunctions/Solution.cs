using System;

namespace Bijective
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => int.Parse(x) - 1);

            int[] reference = new int[n];

            for (int i = 0; i < n; i++)
            {
                reference[i] = i;
            }

            bool bijective = true;

            for (int i = 0; i < n; i++)
            {
                if (reference[arr[i]] == arr[i])
                    reference[arr[i]] = -1;
                else
                {
                    bijective = false;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (reference[i] != -1)
                {
                    bijective = false;
                    break;
                }
            }

            if (bijective)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
