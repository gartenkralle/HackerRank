using System;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int exceedUp = 0;
            int exceedDown = 0;

            int lowest = s[0];
            int highest = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if(s[i] > highest)
                {
                    highest = s[i];
                    exceedUp++;
                }
                else if(s[i] < lowest)
                {
                    lowest = s[i];
                    exceedDown++;
                }
            }

            Console.WriteLine("{0} {1}", exceedUp, exceedDown);
        }
    }
}
