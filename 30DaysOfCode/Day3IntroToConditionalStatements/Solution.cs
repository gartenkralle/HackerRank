using System;

namespace Day3IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            if (((N % 2) == 1) || (((N % 2) == 0) && (N >= 6) && (N <= 20)))
                Console.WriteLine("Weird");

            if ((N % 2) == 0)
            {
                if (((N >= 2) && (N <= 5)) || (((N % 2) == 0) && (N > 20)))
                    Console.WriteLine("Not Weird");
            }
        }
    }
}
