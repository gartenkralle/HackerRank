using System;

namespace Day5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int res = T * i;

                Console.WriteLine(T + " x " + i + " = " + res);
            }
        }
    }
}
