using System;
using System.Globalization;
using System.Threading;

namespace Day2Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            double M = Double.Parse(Console.ReadLine());
            int T = Int32.Parse(Console.ReadLine());
            int X = Int32.Parse(Console.ReadLine());            

            double tip = M * ((double)T / 100);
            double tax = M * ((double)X / 100);

            double sum = Math.Round(M + tip + tax);

            Console.WriteLine("The total meal cost is " + sum + " dollars.");
        }
    }
}
